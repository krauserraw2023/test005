Option Explicit On
'version del form3
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.SubTipoDocJudicial
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Type.Enumeracion.Licencia
Imports System.Linq
Imports Type
Imports APPControls.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Registro.Penal.Busqueda
    Public Class frmMant
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

        Public Property InternoID() As Integer = -1
        Public Property IDInternoHistorico As Integer = -1
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
#Region "Propiedades_Grilla"
        'Private ReadOnly Property GrillaAliasCodigo() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        With Me.dgwAlias
        '            intValue = .SelectedRows(0).Cells("col_ali_id").Value
        '        End With
        '        Return intValue
        '    End Get
        'End Property
        'Private ReadOnly Property GrillaAliasIngreso() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        With Me.dgwAlias
        '            intValue = .SelectedRows(0).Cells("col_ing_id").Value
        '        End With
        '        Return intValue
        '    End Get
        'End Property
        Private ReadOnly Property GrillaFamiliaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                'With Me.dgwFamilia
                '    intValue = .SelectedRows(0).Cells("col_fam_id").Value
                'End With
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFamiliaIngresoID() As Integer
            Get
                Dim intValue As Integer = -1
                'With Me.dgwFamilia
                '    intValue = .SelectedRows(0).Cells("col_num_ing_id").Value
                'End With
                Return intValue
            End Get
        End Property

#End Region
#Region "Propiedades_RegionPenal"
        Public Property RegionID() As Short = -1
        Public Property RegionNombre() As String = ""
        Public ReadOnly Property RegionPenalNombre() As String
            Get
                Dim value As String = ""
                value = Me.RegionNombre & "-" & Me.PenalNombre
                Return value
            End Get
        End Property
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
        Public ValorIngreso As Boolean = False
        Public ValorIngreso0 As Boolean = False
        Dim objBssIng As New Bussines.Registro.Ingreso
        Public Sub ComboNumIngreso()
            If Me.InternoID < 1 Then
                Exit Sub
            End If

            objBssIng = New Bussines.Registro.Ingreso
            Dim objEnt As New Entity.Registro.Ingreso
            Dim objEntCol2 As New Entity.Registro.IngresoCol
            With objEnt
                .InternoID = Me.InternoID
                .PenalID = Me.PenalID
            End With

            objEntCol2 = objBssIng.ListarNroIngreso(Me.InternoID, Me.PenalID)

            With Me.cbbNroIngresos
                .DataSource = objEntCol2
                .DisplayMember = "IngresoNroLetra"
                .ValueMember = "Codigo"
            End With

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
            Me.cbbPabellon.CodigoPadre = Me.PenalID
            Me.cbbPabellon.LoadUsc()

        End Sub

#End Region
#Region "Validar"
        Public Sub ValidarDuplicadosIngreso()
            If Me.InternoID < 1 Then
                Exit Sub
            End If

            objBssIng = New Bussines.Registro.Ingreso

            Dim objEntCol2 As New Entity.Registro.IngresoCol

            Dim objEnt As New Entity.Registro.Ingreso
            objEnt.InternoID = Me.InternoID
            objEnt.PenalID = Me.PenalID

            objEntCol2 = objBssIng.ListarNroIngreso(Me.InternoID, Me.PenalID)
            Dim objEntCol3 As New Entity.Registro.IngresoCol

            For Each obj2 As Entity.Registro.Ingreso In objEntCol2
                If obj2.IngresoNro = 0 Then
                    ValorIngreso0 = True
                End If
            Next
            For Each obj2 As Entity.Registro.Ingreso In objEntCol2
                If objEntCol3.Count = 0 Then
                    objEntCol3.Add(obj2)
                Else
                    For Each obj3 As Entity.Registro.Ingreso In objEntCol3
                        If obj2.IngresoNro = obj3.IngresoNro Then
                            ValorIngreso = True
                            Exit For
                            Exit For
                        End If
                    Next
                    objEntCol3.Add(obj2)
                End If
            Next
            If ValorIngreso = True And ValorIngreso0 = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados y Nº de ingreso [0]." + Chr(13) +
                                                                        "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                        "Ir a la lista de ingresos.")
                tbpInterno.Enabled = False
                tbpResoluciones.Enabled = False
                cbbNroIngresos.Focus()
            ElseIf ValorIngreso = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) +
                                                                        "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                        "Ir a la lista de ingresos.")
                tbpInterno.Enabled = False
                tbpResoluciones.Enabled = False
                cbbNroIngresos.Focus()
            ElseIf ValorIngreso0 = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un Nº de ingreso [0]." + Chr(13) +
                                                                        "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                        "Ir a la lista de ingresos.")
                tbpInterno.Enabled = False
                tbpResoluciones.Enabled = False
                cbbNroIngresos.Focus()

            End If
        End Sub
        Private Sub DataValidarReniec()

            If ValidarFichaReniec() = True Then

                Dim CodInterno As Integer = Me.InternoID
                If CodInterno < 1 Then
                    Exit Sub
                End If

                Dim EntInternoRnc As New Entity.Registro.InternoReniec
                EntInternoRnc.InternoID = CodInterno

                objBssInternoRnc = New Bussines.Registro.InternoReniec
                Dim intInternoReniecID As Integer = objBssInternoRnc.InternoValidado(EntInternoRnc)   'ListarOutputConsulta
                If intInternoReniecID < 1 Then 'Fase 1
                    'UscValidacionReniec1._CondicionBusqueda = 1
                    UscValidacionReniecV21._VarHistorico = -1
                    UscValidacionReniecV21._Contador = intInternoReniecID
                    UscValidacionReniecV21._InternoID = CodInterno
                Else 'Fase 2 Lista validados > 0
                    UscValidacionReniecV21._VarHistorico = 0
                    UscValidacionReniecV21._Contador = intInternoReniecID
                    UscValidacionReniecV21._InternoID = CodInterno
                End If

            End If
        End Sub
        Private CodigoInternoRnc As Integer = -1

        Private Sub DatosPersonalesVerificacionRnc()
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            objBssInternoRnc = New Bussines.Registro.InternoReniec
            Dim obEntRnc As New Entity.Registro.InternoReniec
            obEntRnc.InternoID = Me.InternoID
            obEntRnc = objBssInternoRnc.ListarUltimaValidacion(obEntRnc)
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
                        Dim avs = .TipoBusquedaID
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
        Dim objEntInt As Entity.Registro.Interno
        Private Sub ListarCabecera()

            objBssInterno = New Bussines.Registro.Interno

            objEntInt = New Entity.Registro.Interno

            Me.txtCodigo.Text = Me.CodigoRPInterno

            objEntInt = objBssInterno.Listar_v6(Me.InternoID)

            Me.InternoApePaternoAux = objEntInt.ApellidoPaterno
            Me.InternoApeMaternoAux = objEntInt.ApellidoMaterno
            Me.InternoNombresAux = objEntInt.Nombres
            Me.txtInterno.Text = Me.InternoApeyNomHis(objEntInt.ApellidoPaterno, objEntInt.ApellidoMaterno, objEntInt.Nombres)
            Me.CabeceraEstado = Bussines.Registro.Interno.EstadoNombre(Me.InternoID)
            Me.txtRegionPenal.Text = Me.RegionPenalNombre
            Me.InternoEstado = objEntInt.EstadoID
        End Sub
        Private Sub ListarCodigoRP()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            Dim objEnt As New Entity.Registro.Interno
            objBssInterno = New Bussines.Registro.Interno

            objEnt = objBssInterno.Listar_v6(Me.InternoID)

            With objEnt
                '/*datos generales*/
                Me.CodigoRPInterno = .CodigoRP
                Me.InternoEstado = .EstadoID
            End With
            ListarCabecera()
        End Sub

        Private Sub ListarDataInterno(objEnt As Entity.Registro.Interno)

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            With objEnt
                '/*datos generales*/
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
                Me.PabellonID = .PabellonID
                Me.Pabellon = .PabellonNombre
                Me.Obs = .Obs
                '/*region y penal*/
                Me.RegionID = .RegionID
                Me.RegionNombre = .RegionNombre
                Me.PenalID = .PenalID
                Me.PenalNombre = .PenalNombre
                Me.InternoApePaternoAux = Me.InternoApePaterno
                Me.InternoApeMaternoAux = Me.InternoApeMaterno
                Me.InternoNombresAux = Me.InternoNombres
                Me.chk_Homonimia.Checked = IIf(.Homonimia = True, True, False)
                Me.chk_Homonimia.Enabled = False
                Me.InternoEstado = .EstadoID
                Me._IdiomaNativoId = .IdiomaNativoId
                Me.GeneroPersonaId = .GeneroId
                Me.txtCentroTrabajo.Text = .CentroTrabajo
                'Me.CodigoUnicoInterno = .CodigoUnicoInterno
                Me.NombreClaveInterno = .NombreClaveInterno
                Me.ReligionId = .ReligionId
                Me.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                Me.CodigoRangoId = .CodigoRangoId

            End With

        End Sub
        Private Sub ListarInternoHistorico(objEnt As Entity.Registro.InternoHistorico)

            If Me.InternoID < 1 Or Me._IDIngreso < 1 Then
                Exit Sub
            End If

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
                Me.RegionID = .RegionID
                Me.RegionNombre = .RegionNombre
                Me.PenalID = .PenalID
                Me.PenalNombre = .PenalNombre
                Me.InternoApePaternoAux = .ApellidoPaterno
                Me.InternoApeMaternoAux = .ApellidoMaterno
                Me.InternoNombresAux = .Nombres
                Me.UscAuditUser1.LoadAudit(Me.InternoID, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Me.txtCentroTrabajo.Text = .CentroTrabajo
                Me._IdiomaNativoId = .IdiomaNativoId
                Me.GeneroPersonaId = .GeneroId
                Me.NombreClaveInterno = .NombreClaveInterno
                Me.ReligionId = .ReligionId
                Me.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                Me.CodigoRangoId = .CodigoRangoId
            End With

        End Sub
        Private Sub ListarData()

            If Me.InternoID < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If

            objBssHistorico = New Bussines.Registro.InternoHistorico

            Dim objEntIng As New Entity.Registro.Ingreso
            Dim objEnInternoHisto As New Entity.Registro.InternoHistorico
            Dim objEnInternoFiltroHisto As New Entity.Registro.InternoHistorico
            objBssInterno = New Bussines.Registro.Interno
            If Me._IDIngreso > 0 Then

                objEnInternoFiltroHisto.InternoID = Me.InternoID
                objEnInternoFiltroHisto.IngresoID = Me._IDIngreso

                objEnInternoHisto = objBssHistorico.Listar(objEnInternoFiltroHisto)

                If objEnInternoHisto Is Nothing Then
                    Dim objEntInterno As New Entity.Registro.Interno
                    'Dim objEntInternoFiltro As New Entity.Registro.Interno

                    'objEntInternoFiltro.Codigo = Me.InternoID
                    objEntInterno = objBssInterno.Listar_v6(Me.InternoID)
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me.InternoID, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Else
                    If objEnInternoHisto.InternoID < 1 Then
                        'no existe el registro historico del interno, hay que crearlo de la tabla int_interno
                        objEnInternoHisto = objBssHistorico.Listar_Data_Interno(Me.InternoID, Me._IDIngreso)
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
                            Dim objEntInterno As New Entity.Registro.Interno
                            'Dim objEntInternoFiltro As New Entity.Registro.Interno

                            'objEntInternoFiltro.Codigo = Me.InternoID
                            objEntInterno = objBssInterno.Listar_v5(Me.InternoID)
                            ListarDataInterno(objEntInterno)
                        Else
                            ListarInternoHistorico(objEnInternoHisto)
                        End If
                    End If
                    Me.UscAuditUser1.LoadAudit(objEnInternoHisto.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                End If
            Else
                'listar los datos del interno 

                Dim objEntInterno As New Entity.Registro.Interno
                'Dim objEntInternoFiltro As New Entity.Registro.Interno

                'objEntInternoFiltro.Codigo = Me.InternoID
                objEntInterno = objBssInterno.Listar_v5(Me.InternoID)
                If objEntInterno.Codigo > 0 Then
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me.InternoID, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(
                    "No se ha encontrado al Interno o posiblemente haya sido eliminado. Actualice la busqueda.")
                    Me.Close()
                End If
            End If
            chk_Homonimia.Enabled = False
            ListarCabecera()
            EnabledControles(True)

            UscGradosAcademicos1._PenalId = Me.PenalID
            UscGradosAcademicos1._RegionId = Me.RegionID
            UscGradosAcademicos1._IngresoId = Me._IDIngreso

            UscIdiomaInterno1._PenalId = Me.PenalID
            UscIdiomaInterno1._RegionId = Me.RegionID
            UscIdiomaInterno1._IngresoId = Me._IDIngreso

            Me.UscDomicilio1._PenalId = Me.PenalID
            Me.UscDomicilio1._RegionId = Me.RegionID
            Me.UscDomicilio1._IngresoId = Me._IDIngreso
            Me.UscDomicilio1._IngresoNroLetra = cbbNroIngresos.Text
            Me.UscDomicilio1._LoadUsc()
            'ListarUbigeoGeoreferencia()
        End Sub

        Private Sub LoadUscFotografia()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            With uscFotoPerfiles
                ._InternoID = Me.InternoID
                ._InternoCodigoRP = Me.CodigoRPInterno
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .InternoFotoID = -1
                .InternoIngresoId = Me._IDIngreso
                .LoadUsc()
                uscFotoPerfiles.DataGrieView_Click()
            End With

        End Sub

        Private Sub ListarDatosComplementarios()

            If Me.InternoID < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If

            With UscIdiomaInterno1
                ._InternoId = Me.InternoID
                '._IngresoInpeID = Me.IDIngresoINPE
                ._IngresoId = Me._IDIngreso
                ._RegionId = Me.RegionID
                ._PenalId = Me.PenalID
                ._IngresoNroLetra = cbbNroIngresos.Text
                .TipoLicencia = enmTipoLicencia.PenalLimaProvincia
                ._LoadUsc()
            End With

            With UscGradosAcademicos1
                ._PenalId = Me.PenalID
                ._RegionId = Me.RegionID
                '._IngresoInpeID = Me.IDIngresoINPE
                ._IngresoId = Me._IDIngreso
                ._InternoId = Me.InternoID
                ._IngresoNroLetra = cbbNroIngresos.Text
                .TipoLicencia = enmTipoLicencia.PenalLimaProvincia
                ._LoadUsc()
            End With

            With UscDomicilio1
                ._PenalId = Me.PenalID
                ._RegionId = Me.RegionID
                '._IngresoInpeID = Me.IDIngresoINPE
                ._IngresoId = Me._IDIngreso
                ._InternoId = Me.InternoID
                ._IngresoNroLetra = cbbNroIngresos.Text
                .TipoLicencia = enmTipoLicencia.PenalLimaProvincia
                ._LoadUsc()
            End With

            listarUscPoblacionLenguaMaterna()

            EnabledControles(True)

        End Sub
        Public Sub LoadUscNombresAsociados()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            With UscGrillaNombresAsociadosV21
                ._InternoID = Me.InternoID
                ._IngresoID = Me._IDIngreso
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID

                ._LoadUsc()
            End With
        End Sub
        Private Sub LoadUscBandas()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            With UscGrillaBandasV21
                ._InternoID = Me.InternoID
                ._InternoIngresoID = Me._IDIngreso
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._LoadUsc()
            End With
        End Sub
        Private Sub ListarAlias()

            With UscAlias21
                .InternoID = Me.InternoID
                .IngresoID = Me._IDIngreso
                ._VisibleGrabar = blnEscrituraRegistro
                ._VisibleEliminar = blnEliminarRegistro
                ._Load()
            End With
        End Sub
        Private Sub ListarBandas()
            With UscBandas21
                .InternoID = Me.InternoID
                .IngresoID = Me._IDIngreso
                ._Load()
            End With
        End Sub
        Private Sub ListarFamilia()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            With UscFamilias1
                ._IDInterno = Me.InternoID
                ._IDIngreso = Me._IDIngreso
                ._LoadUsc()
            End With

        End Sub

        Private Sub LoadUscOdontograma()

            If Me.InternoID < 1 Then Exit Sub

            With UscOdont
                ._InternoId = Me.InternoID
                ._IngresoID = Me._IDIngreso
                '._IngresoInpeID = Me._IDIngresoINPE
                .TipoLicencia = enmTipoLicencia.PenalProvincia ' .Carceleta
                ._RegionId = Me.RegionID
                ._PenalId = Me.PenalID
                ._LoadUsc()
            End With

        End Sub

        Public Sub ListarResoluciones()
            If Me._IDIngreso < 1 Or Me.InternoID < 1 Then Exit Sub
            With Me.UscResolucionesMain1
                ._Codigo = -1
                ._InternoID = Me.InternoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._NroIngresoID = Me._IDIngreso
                .LoadUsc()
            End With

        End Sub
        Private Sub Listar_Expedientes()

            If Me._IDIngreso < 1 Or Me.InternoID < 1 Then Exit Sub
            'cargar mandatos de detencion
            With Me.UscMandatoDetencion
                .InternoID = Me.InternoID
                .InternoEstado = Me.InternoEstado
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .IngresoID = Me._IDIngreso
                ._FormEscritura = blnEscrituraRegistro
                ._LoadUsc()
            End With

        End Sub
        Private Sub ListarMovimientosIngreso()
            If Me._IDIngreso < 1 Or Me.InternoID < 1 Then Exit Sub
            With Me.UscMovimiento1
                '._Codigo = -1
                ._InternoID = Me.InternoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._NroIngresoID = Me._IDIngreso
                .LoadUsc()
            End With
        End Sub

        Private Sub LoadUscHuellas()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            With UscVisorDetalleHuellas1
                ._InternoId = Me.InternoID
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
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
        Private Sub listarUscPoblacionLenguaMaterna()

            With UscEtniaLenguaMaterna_v21
                ._load(Me.InternoID, Me.RegionID, Me.PenalID)
            End With

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
        Private Sub ListarUbigeoDomicilio(ByVal Codigo As Integer)

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
                    Me.DomicilioDepartamento = .Departamento
                    Me.DomicilioProvincia = .Provincia
                    Me.DomicilioDistrito = .Distrito
                End With
            End If

        End Sub
#End Region
#End Region
#Region "Listar_UserControl_Clasificacion"

        Private Sub ListarClasificacionRegimen()

            If Me.InternoID < 1 Then Exit Sub

            With Me.UscFichaClasificacion1
                ._IDInterno = Me.InternoID
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me._IDIngreso
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen.EnmFichaTab.enmRegimen
                ._ListarUsc()
            End With

        End Sub

        Private Sub ListarClasificacionEtapa()

            If Me.InternoID < 1 Then Exit Sub

            With Me.UscFichaClasificacion2
                ._IDInterno = Me.InternoID
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me._IDIngreso
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen.EnmFichaTab.enmEtapa
                ._ListarUsc()
            End With

        End Sub
        Private Sub ListarPabellonUbicacion()

            If Me.InternoID < 1 Then Exit Sub

            With Me.UscPabellon1
                ._IDInterno = Me.InternoID
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me._IDIngreso
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                'permisos                
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._ListarUsc()
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
                blnValue = False
                Return blnValue
            End If

            '/*fecha nacimiento*/
            If Me.InternoFechaNac < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
               "Ingrese fecha de nacimiento del Interno")
                Me.dtpFechaNac.Focus()
                blnValue = False
                Return blnValue
            End If

            If Me.InternoFechaNac < 1 Then
                If chk_Obs_DNI.Checked = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                   "Si marco el check [<18 Años], debe ingresar un menor de Edad, con la justificación que lo motiva")
                    Me.dtpFechaNac.Focus()
                    blnValue = False
                    Return blnValue
                End If
            Else
                '/*fecha nacimiento>18 */
                Dim intAnios As Integer = 0
                intAnios = Legolas.Components.FechaHora.FechaCalcularAnio(Me.dtpFechaNac.ValueLong,
                                                                          Legolas.Configuration.Aplication.FechayHora.FechaLong, True)
                Dim dteFechaNac As Date = Me.dtpFechaNac.Value
                Dim dteFechaMay18 As Date = DateAdd(DateInterval.Year, -18, Now)
                'If Me.InternoFechaNac > Legolas.Configuration.Aplication.FechayHora.FechaLong() Then
                If chk_Obs_DNI.Checked = False Then
                    If intAnios < 18 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La edad del interno corresponde a un menor de Edad, en caso requiera ingresar un menor de Edad," + Chr(13) +
                        "active el check [<18 Años] e ingrese una justificación")
                        Me.dtpFechaNac.Focus()
                        blnValue = False
                        Return blnValue
                    End If
                Else
                    If intAnios > 17 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La edad del interno pertenece aun mayor de edad," + Chr(13) +
                        "debe tener una fecha de nacimiento menor a la fecha actual")
                        Me.dtpFechaNac.Focus()
                        blnValue = False
                        Return blnValue
                    End If
                    If txtObs_dni.Text = "" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                          "La edad del interno es la de un menor de edad," + Chr(13) +
                          "debe ingresar la justificación que la motiva.")
                        Me.txtObs_dni.Focus()
                        blnValue = False
                        Return blnValue
                    End If

                End If
            End If

            'tipo y numero documento
            If Me.TipoDocumento > 0 And Me.NumeroDocumento <> "" Then
                objBssInterno = New Bussines.Registro.Interno
                Dim objEnti As New Entity.Registro.Interno
                With objEnti
                    .Codigo = Me.InternoID
                    .TipoDocumentoID = Me.TipoDocumento
                    .NumeroDocumento = Me.NumeroDocumento
                    .NumeroDocumentoAux = Me.NumeroDocumentoAux
                    .RegionID = Me.RegionID
                    .PenalID = Me.PenalID
                End With
                If Me.InternoID > 0 Then
                    If Me.NumeroDocumento = Me.NumeroDocumentoAux Then
                    Else
                        If objBssInterno.ValidarNumeroDocumento(objEnti) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(
                             "El 'Tipo de documento' y 'Numero de documento'" + Chr(13) +
                             "pertenece a otro interno")
                            txtNumDoc.Focus()
                            blnValue = False
                            Return blnValue
                        End If
                    End If
                Else
                    If objBssInterno.ValidarNumeroDocumento(objEnti) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                         "El 'Tipo de documento' y 'Numero de documento'" + Chr(13) +
                         "pertenece a otro interno")
                        txtNumDoc.Focus()
                        blnValue = False
                        Return blnValue
                    End If
                End If
            ElseIf Me.TipoDocumento < 1 And Me.NumeroDocumento <> "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "El Número de documento ha sido llenado, seleccione un tipo de documento")
                cbbTipoDoc.Focus()
                blnValue = False
                Return blnValue
            End If

            '---------Validar Homonimia--------------
            Dim objEnt As New Entity.Registro.Interno
            Dim strMensaje As String = ""
            Dim blnHomonimia As Boolean = False
            With objEnt
                .Codigo = Me.InternoID
                .ApellidoPaterno = Me.InternoApePaterno
                .ApellidoMaterno = Me.InternoApeMaterno
                .Nombres = Me.InternoNombres
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                If chk_Homonimia.Checked = True Then
                Else
                    If Me.InternoID < 1 Then
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
                            blnValue = False
                            Return blnValue
                        ElseIf blnHomonimia = False And chk_Homonimia.Checked = True Then
                            strMensaje = "Los apellidos y nombres consignados, no tienen campos de 'Homonimia'." + Chr(13) +
                                               "Si desea grabar, desactive el campo 'Homonimia', y hacer click en el boton [Grabar]"
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                            Me.chk_Homonimia.Focus()
                            blnValue = False
                            Return blnValue
                        End If
                    Else
                        If Me.InternoApePaterno = Me.InternoApePaternoAux And Me.InternoApeMaterno = Me.InternoApeMaternoAux And Me.InternoNombres = Me.InternoNombresAux Then
                            Dim valor As Integer = objBssInterno.ValidarApellidosyNombresUpd(objEnt)
                            If valor > 0 Then
                                strMensaje = "Los apellidos y nombres consignados, ya se encuentran en la base de datos." + Chr(13) +
                                  "Si desea grabar, active el campo [Homonimia], y hacer click en el boton [Grabar]"
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                                Me.chk_Homonimia.Focus()
                                blnValue = False
                                Return blnValue
                            Else
                                blnValue = True
                                'Return blnValue
                            End If
                        Else
                            Dim valor As Integer = objBssInterno.ValidarApellidosyNombres(objEnt)
                            If valor = 0 Then

                                blnValue = True

                            Else
                                strMensaje = "Los apellidos y nombres consignados, ya se encuentran en la base de datos." + Chr(13) +
                                "Si desea grabar, active el campo [Homonimia], y hacer click en el boton [Grabar]"
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                                Me.chk_Homonimia.Focus()
                                blnValue = False
                                Return blnValue
                            End If
                        End If
                    End If
                End If

            End With

            Return blnValue
        End Function
        Private Sub AGrabar()

            Select Case Me.tbcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name, Me.tbpDatosComplement.Name
                    If btnGrabar.Text = "Modificar" Then
                        EnabledControles(False)
                        btnGrabar.Image = My.Resources.Drive___USB_32
                        btnGrabar.Text = "&Grabar"

                        btnIngreso.Image = My.Resources.anular2
                        btnIngreso.Text = "Cancelar"

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

            objBssInterno = New Bussines.Registro.Interno
            Dim intValue As Integer = -1

            Me.InternoApePaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.InternoApePaterno)
            Me.InternoApeMaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.InternoApeMaterno)
            Me.InternoNombres = Legolas.Components.Cadena.LimpiarEspacios(Me.InternoNombres)

            Dim obEntInterno As New Entity.Registro.Interno
            With obEntInterno
                .Codigo = Me.InternoID
                .CodigoRP = Me.CodigoRPInterno
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
                .CentroReclusionMenorId = Me.CentroReclusionMenorId
                .VersionRegistro = "V5_P"
            End With

            If Me._IDIngreso > 0 Then
                'grabar interno historico
                objBssHistorico = New Bussines.Registro.InternoHistorico
                Dim ValorHis As Integer = objBssHistorico.Grabar_Interno(Me.IDInternoHistorico, Me._IDIngreso, obEntInterno)
                Me.UscAuditUser1.LoadAudit(Me.IDInternoHistorico, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                intValue = obEntInterno.Codigo

            Else
                'grabar datos del interno
                Dim blnaux As Boolean = False
                If Me.InternoID < 1 Then
                    blnaux = True
                End If

                intValue = objBssInterno.Grabar2(obEntInterno)

                If intValue > 0 Then
                    Me.InternoID = intValue
                    If blnaux = True Then
                        Me.NumeroDocumentoAux = Me.NumeroDocumento
                    End If
                    Me.UscAuditUser1.LoadAudit(Me.InternoID, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
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
            End If

        End Sub
        'Private Sub AGrabarInternoGeoreferencia()
        '    If CodigoInternoRnc < 1 Then
        '        Exit Sub
        '    End If
        '    If Me.Latitud.Length = 0 Or Me.Longitud.Length = 0 Then
        '        Exit Sub
        '    End If
        '    objBssInternoRnc = New Bussines.Registro.InternoReniec
        '    Dim obj As New Entity.Registro.InternoReniec
        '    With obj
        '        .Codigo = Me.CodigoInternoRnc
        '        .InternoID = Me.InternoID
        '        .RegionID = Me.RegionID
        '        .PenalID = Me.PenalID
        '        .Latitud = Me.Latitud
        '        .Longitud = Me.Longitud
        '    End With
        '    objBssInternoRnc.GrabarGeo(obj)
        'End Sub
        Private Sub AEliminarInterno()

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de eliminar el registro, grabe los datos basicos del interno")
                Exit Sub
            End If
            Dim strMensaje As String = "No se puede eliminar el Interno." + Chr(13) +
                         "Porque cuenta con : "

            If (New Bussines.Registro.DocumentoJudicial).CantidadDocumentosExpedientes(Me.InternoID, Me.PenalID) > 0 Then
                strMensaje = strMensaje + " Documentos Judiciales activos."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If
            Dim ent As New Entity.Registro.InternoMovimiento
            ent.InternoID = Me.InternoID
            If ((New Bussines.Registro.InternoMovimiento).ListarGrilla_LM(ent).Count) > 0 Then
                strMensaje = strMensaje + " Movimientos activos."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If
            Dim objIngreso As New Entity.Registro.Ingreso
            objIngreso.InternoID = Me.InternoID
            If ((New Bussines.Registro.Ingreso).ListarNroIngreso(Me.InternoID, Me.PenalID).Count) > 0 Then
                strMensaje = strMensaje & "Ingresos activos."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If

            strMensaje = "Esta seguro de eliminar definitivamente el registro del interno de su penal."
            strMensaje = strMensaje & " Al realizar esta operacion el registro del interno NO Pasara al estado inactivo."
            strMensaje = strMensaje & Chr(13)

            strMensaje = strMensaje & "" + Chr(13) +
                  "Esta accion eliminará los siguientes datos: " + Chr(13) +
                  "1. Identificacion del Interno " + Chr(13) +
                  "   (Datos personales, Fotos, Nombres asociados, etc)" + Chr(13) +
                  "2. Datos de Lista de Expedientes " + Chr(13) +
                  "3. Datos de Documentos judiciales y resoluciones" + Chr(13) +
                  "4. Datos de Movimiento de ingreso y egreso." + Chr(13) +
                  "" + Chr(13) +
                  ""
            strMensaje = strMensaje & "Aun asi desea continuar con la operacion?"
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = Windows.Forms.DialogResult.Yes Then

                Dim objBss As New Bussines.Registro.Interno
                Dim Value As Integer = -1

                Value = objBss.Eliminar(Me.InternoID, "")

                If Value > 0 Then
                    Me.DialogResult = DialogResult.Yes
                    Me.Close()
                End If

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
            value = objBss.GrabarEstado(UscGrillaBandasV21.GrillaID, 0, intIdDocJudAnula)

            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            Dim intIdEstadoBand As Integer = -1
            UscGrillaBandasV21._LoadUsc()

        End Sub

        Private Sub EnabledControles(Valor As Boolean)
            Select Case Me.tbcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name, Me.tbpDatosComplement.Name 'datos 
                    Me.txtNomClaveInt.ReadOnly = Valor
                    Me.txtCentroTrabajo.ReadOnly = Valor
                    Me.txtApePat.ReadOnly = Valor
                    Me.txtApeMat.ReadOnly = Valor
                    Me.txtNom.ReadOnly = Valor
                    Me.txtDecadactDer.ReadOnly = Valor
                    Me.txtDecadactIzq.ReadOnly = Valor
                    Me.txtLibro.ReadOnly = Valor
                    Me.txtFolio.ReadOnly = Valor
                    Me.txtPabellon.ReadOnly = Valor
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

        Private Sub FRM_ListaIngreso()

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.cbbNroIngresos.Text = "[Por regularizar]" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un ingreso, regularizar el Nº de ingreso [0].")
                Exit Sub
            End If

            If NuevoClickfrmIngreso = True Then
                If btnIngreso.Text = "Cancelar" Then
                    EnabledControles(True)
                    btnGrabar.Image = My.Resources._1277961326_folder_edit
                    btnGrabar.Text = "Modificar"

                    btnIngreso.Image = My.Resources.add_32
                    btnIngreso.Text = "Nuevo" + Chr(13) +
                                      "Ingreso"

                    ListarData()

                    'listar datos complementarios
                    If Me.tbcDatosInternos.SelectedTab.Name = Me.tbpDatosComplement.Name Then
                        ListarDatosComplementarios()
                    End If

                    Me.InternoApePaterno = Me.InternoApePaternoAux
                    Me.InternoApeMaterno = Me.InternoApeMaternoAux
                    Me.InternoNombres = Me.InternoNombresAux

                    Exit Sub
                End If
            End If

            Dim frm As New Registro.Identificacion.v5.frmIngresoPopup3
            With frm
                .InternoID = Me.InternoID
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                ._NuevoClick = Me.NuevoClickfrmIngreso
                ._ValidarIngreso = Me.ValorIngreso
                ._ValidarIngreso0 = Me.ValorIngreso0
                ._LoadUsc()

                Dim ContadorIngresos As Integer = frm.GrillaDgwFilas
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro

                If frm.ShowDialog = DialogResult.OK Then
                    ComboNumIngreso()
                    ListarData()
                    DatosPersonalesVerificacionRnc()
                    uscFotoPerfiles.InternoIngresoId = Me._IDIngreso
                    uscFotoPerfiles.LoadUsc()
                    ListarResoluciones()
                    LoadUscNombresAsociados()
                    LoadUscBandas()
                    UscMandatoDetencion.IngresoID = Me.cbbNroIngresos.SelectedValue
                    UscMandatoDetencion._LoadUsc()
                    UscResolucionesMain1._NroIngresoID = Me.cbbNroIngresos.SelectedValue
                    UscResolucionesMain1.LoadUsc()
                    If tbcDatosInternos.SelectedTab.Name = "tbpReniec" Then
                        If Me._IDIngreso < 1 Then
                            UscValidacionReniecV21.ListarInternoValidado(Me.InternoID)
                            tbcDatosInternos.SelectedIndex = 0
                        Else
                            DataValidarReniec()
                        End If
                    ElseIf tbcDatosInternos.SelectedTab.Name = "tbpAlias" Then
                        UscAlias21._Load()
                    ElseIf TabControl3.SelectedTab.Name = "tbpListaExpedientes" Then
                        UscMandatoDetencion.IngresoID = Me.cbbNroIngresos.SelectedValue
                        UscMandatoDetencion._LoadUsc()
                    ElseIf TabControl3.SelectedTab.Name = "tbpMovimientos" Then

                    End If
                    UscMovimiento1.LoadUsc()
                    ListarFamilia()

                    EnabledControles(IIf(frm.blnNuevosDatos = True, False, True))

                    Dim entIngCol As New Entity.Registro.IngresoCol
                    Dim EntInt As New Entity.Registro.Ingreso
                    EntInt.InternoID = Me.InternoID
                    EntInt.PenalID = Me.PenalID
                    entIngCol = objBssIng.Listar(EntInt)
                    Dim blnValor As Boolean = False
                    Dim blnValor2 As Boolean = False
                    Dim intValor As Integer = -1
                    For Each Ent As Entity.Registro.Ingreso In entIngCol
                        If intValor = Ent.IngresoNro Then
                            blnValor2 = True
                        Else
                            intValor = Ent.IngresoNro
                        End If

                        If Ent.IngresoNro = 0 Then
                            blnValor = True
                        End If
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
        Private Sub FRM_Mant_SeniaParticular(IdSeniaPart As Integer)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmSeñasPartiPopup
            With frm
                .Codigo = IdSeniaPart
                ._InternoID = Me.InternoID
                ._InternoIngresoId = Me._IDIngreso
                ._InternoIngresoNro = Val(cbbNroIngresos.Text)
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog = DialogResult.OK Then
                    uscFotoPerfiles.ListarSenasParti()
                End If
            End With
        End Sub
        Private Sub FRM_Mant_Rasgo(IdRasgo As Integer)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmRasgosPartiPopup
            With frm
                .Codigo = IdRasgo
                ._InternoID = Me.InternoID
                ._InternoIngresoId = Me._IDIngreso
                ._NroIngreso = Val(cbbNroIngresos.Text)
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog = DialogResult.OK Then
                    uscFotoPerfiles.ListarDataRasgo()
                End If
            End With
        End Sub
        Private Sub FRM_Mant_Fotos(InternoID As Integer, RestringirEdicion As Boolean)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Captura.frmFotoPerfiles
            With frm
                ._InternoID = Me.InternoID
                .Codigo = InternoID
                .PenalID = Me.PenalID
                .RegionID = Me.RegionID
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
        Private Sub FRM_Mant_NombresAsociados(ByVal Nuevo As Boolean, ByVal Codigo As Integer, objEntNA As Entity.Registro.NombreAsociado)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Nuevo = True Then
                Dim frm1 As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
                With frm1
                    .Codigo = Codigo
                    .InternoID = Me.InternoID
                    .IngresoID = Me._IDIngreso
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    'permisos
                    ._FormEscritura = blnEscrituraRegistro
                    ._FormEliminar = blnEliminarRegistro
                    ._FormReporte = blnReporteRegistro
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        ListarCabecera()
                        ListarData()
                        ListarResoluciones()
                        Listar_Expedientes()
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
                    .InternoID = Me.InternoID
                    'permisos
                    ._FormEscritura = blnEscrituraRegistro
                    ._FormEliminar = blnEliminarRegistro
                    ._FormReporte = blnReporteRegistro
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
                        ListarData()
                        ListarResoluciones()
                        UscGrillaNombresAsociadosV21.Listar()
                        Me.UscGrillaNombresAsociadosV21._LoadUsc()
                    End If
                End With
            End If

        End Sub
        Private Sub FRM_MantenimientoAlias(ByVal Nuevo As Boolean, AliasID As Integer, AliasIngesoID As Integer)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.v5.frmAliasPopup
            With frm
                .InternoID = Me.InternoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                If Nuevo = True Then
                    .Codigo = -1
                    ._NroIngresoID = Me._IDIngreso
                Else
                    .Codigo = AliasID
                    ._NroIngresoID = AliasIngesoID
                End If
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarAlias()
                End If

            End With
        End Sub
        Private Sub FRM_MantenimientoBandas(ByVal Nuevo As Boolean, InternoBandaID As Integer, BandaIngesoID As Integer, objEntColBandas As Entity.Registro.InternoBandaCol)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmInternoBandaV2
            With frm
                .InternoID = Me.InternoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                If Nuevo = True Then
                    .Codigo = -1
                    ._NroIngresoID = Me._IDIngreso
                Else
                    .Codigo = InternoBandaID
                    ._NroIngresoID = BandaIngesoID
                End If
                .objEntCol = objEntColBandas
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarBandas()
                End If

            End With
        End Sub

        Private Function FRM_Mant_Siscrico_Anular() As Integer '24.04.2014 hnrb--> para crear documento judicial de anulacion de registro

            Dim frm As New Registro.Documento.frmDocJudicial
            With frm
                ._DocumentoJudicialID = -1
                ._InternoID = Me.InternoID
                ._IngresoID = Me._IDIngreso
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = DialogResult.OK Then
                    Return ._DocumentoJudicialID
                Else
                    Legolas.Configuration.Aplication.MessageBox.Information("Operación cancelada")
                    Return -1
                End If
            End With
        End Function

        Private Sub FRM_Mant_Siscrico(ByVal Nuevo As Boolean)

            If Me.InternoID < 1 Then
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
                .InternoID = Me.InternoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._VisibleGrabar = blnEscrituraRegistro
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscGrillaBandasV21._LoadUsc()
                End If

            End With
        End Sub

        Private Sub FRM_Mant_Familia(ByVal Nuevo As Boolean, IDFamilia As Integer, objFamCol As Entity.Registro.FamiliarCol)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.v5.frmFamiliarPopupV2
            With frm
                .InternoID = Me.InternoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                If Nuevo = True Then
                    .Codigo = -1
                    ._NroIngresoID = Me._IDIngreso
                    ._objEntColFam = objFamCol
                    ._NuevoFam = Nuevo
                Else
                    .Codigo = IDFamilia
                    ._NroIngresoID = Me._IDIngreso
                    ._objEntColFam = objFamCol
                    ._NuevoFam = Nuevo
                End If
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarFamilia()
                End If
            End With
        End Sub

        Private Sub FRM_VerReportes()

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de visualizar los reportes, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm2 As New Registro.Reporte.frmReportePopupv2
            With frm2
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me.InternoID
                ._InternoApeNom = Me.InternoApeyNom
                ._TipoReporte = Reporte.frmReportePopupv2.enmListarReportes.Interno
                ._VisibleBuscar = False
                ._TipoLicencia = enmTipoLicencia.PenalProvincia

                .ShowDialog()
            End With

        End Sub

        Private Sub FRM_Odontograma(Nuevo As Boolean, IDOdontograma As Integer)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            Dim f As New Registro.Captura.frmOdontogramaPopup

            f._InternoId = Me.InternoID
            f._InternoIngresoId = _IDIngreso
            f._InternoIngresoInpeId = -1 ' Me._IDIngresoINPE
            f._PenalId = Me.PenalID
            f._RegionId = Me.RegionID
            f._TipoLicencia = enmTipoLicencia.PenalProvincia
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
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer)

            If Me.InternoID < 1 Or IngresoCodigo < 1 Then
                MessageBox.Show("Seleccione el numero de ingreso",
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
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoCodigo
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    Me.UscMandatoDetencion._ListarExpediente()

                End If
                Me.UscMandatoDetencion._ListarDelito()
            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer)

            If Me.InternoID < 1 Or IngresoCodigo < 1 Or ExpedienteCodigo < 1 Then
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
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMandatoDetencion._ListarDelito()
                    Me.UscMandatoDetencion._ListarExpediente()
                End If

            End With
        End Sub
        Private Sub FRM_MantAgraviado(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer, ByVal AgraviadoCodigo As Integer)

            If Me.InternoID < 1 Or IngresoCodigo < 1 Or ExpedienteCodigo < 1 Or DelitoCodigo < 1 Then
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
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMandatoDetencion._ListarAgraviado()
                End If
            End With
        End Sub
#End Region

#Region "Resoluciones"
        Private Sub FRM_ListadoExpediente()

            Dim frm As New Registro.Resoluciones.frmVerExpePorResolPopup(_IDIngreso, InternoID)
            frm.ShowDialog()

        End Sub
        Private Sub FRM_Resolucion_Sentencia(TipoResolucion As System.Int32, IDDocumentoJudicial As System.Int32, SubTipo As Integer)

            Select Case TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    FRM_Resolucion_Libertad(IDDocumentoJudicial)
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

            If Me.InternoID < 1 Then
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
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.txtInterno.Text
                ._ResolucionIngRegistrado = ResolucionRegistrada
                ._OpcionListar = Opcion
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormImpresion = blnReporteRegistro
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

            Dim frm As New Registro.Resoluciones.frmResolIngreso
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._DocumentoSubtipo = DocSubTipo
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub
        Private Sub FRM_Resolucion_Libertad(DocJudicialId As Integer)

            Dim frm As New Registro.Resoluciones.frmResolLibertad
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub
        Private Sub FRM_Resolucion_Nota(DocJudicialId As Integer, SubTipo As Integer)
            Select Case SubTipo
                Case enumSubTipo.ProyeccionVencimientoCondena
                    Dim frm As New Registro.Resoluciones.frmProyeccionVencimientoCondena
                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.InternoID
                        ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                        ._RegionID = Me.RegionID
                        ._PenalID = Me.PenalID
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
                Case enumSubTipo.Nota_de_Sentencia, enumSubTipo.Adelanto_de_Fallo
                    Dim frm As New Registro.Resoluciones.frmNotaPeriodo
                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.InternoID
                        ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                        ._RegionID = Me.RegionID
                        ._PenalID = Me.PenalID
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
                        ._InternoId = Me.InternoID
                        ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                        ._RegionID = Me.RegionID
                        ._PenalID = Me.PenalID
                        ._CodigoInterno = Me.CodigoRPInterno
                        ._NombresInterno = Me.InternoApeyNom
                        ._blnNuevoRegistro = False

                        'permisos
                        ._FormEscritura = blnEscrituraRegistro
                        ._FormEliminar = blnEliminarRegistro
                        ._FormReporte = blnReporteRegistro
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
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_ResolucionAvocamiento(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAvocamiento

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_Resol_AmpliacionAutoapertorio(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAmpliaAutoapert

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
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
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_Resol_Detencion(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolDetencionReferenciado

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.InternoID
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub
        Private Sub FRM_Resol_Expediente(DocJudicialId As Integer)
            Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple

            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.InternoID
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub
        Private Sub FRM_Resol_PrisionPreventiva(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolPrisionPreventiva

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.InternoID
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub
        Private Sub FRM_Resol_Aclaratoria(DocJudicialId As Integer)
            'verificar
            Dim frm As New Registro.Resoluciones.frmResolAclaratoriaExpe

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._NuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
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
                ._InternoId = Me.InternoID
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_Resolucion_RevocatoriaLibertad(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolRevocatoriaLibertad

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.InternoID
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_Queda(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmQueda

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.InternoID
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_Resol_AclaratoriaNombres(intIDDocJudicial As Integer)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Resoluciones.frmResolAclaratoriaExpe
            With frm
                ._Codigo = intIDDocJudicial
                ._InternoIngresoId = Me._IDIngreso  'UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._NuevoRegistro = False
                ._Subtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Nombre
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarData()
                    ListarCabecera()
                    ListarResoluciones()
                    UscGrillaNombresAsociadosV21.Listar()
                End If
            End With

        End Sub
        Private Sub FRM_TrasladoHospitalmental(MovimientoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer)
            Dim frm As New Registro.Movimientos.frmMovimientoTrasladoHospitalmental
            With frm
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.TrasladoHospitalmental
                ._NroPendientes = Pendientes
                '._CargarExpedientes = True
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub
        Private Sub FRM_OrdenTraslado(DocJudicialId As Integer, TipoResolucionId As Integer)

            Dim frm As New Registro.Resoluciones.frmOrdenTrasladoHospital
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoId = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = TipoResolucionId
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
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
                ._InternoID = Me.InternoID
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub

        Private Sub FRM_Resol_IntegracionSentencia(DocJudicialId As Integer, TipoDocumento As Integer)
            Dim frm As New Registro.Sentencias.frmResolIntegracionSent
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.InternoID
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = TipoDocumento
                Me.DocumentoTipo = TipoDocumento
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub
        Private Sub FRM_Resol_Conmutacion(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.Sentencias.frmResolSentenciaConmutacion
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.InternoID
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With

        End Sub
        Private Sub FRM_Resol_SentenciaMultiple(DocJudicialId As Integer, TipoResolucion As Integer)
            If TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Then
                Dim frm As New Registro.Sentencias.frmResolIntegracionSent
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoID = Me.InternoID
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    ._InternoID = Me.InternoID
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._TipoResolucion = TipoResolucion
                    ._blnNuevoRegistro = False
                    'permisos
                    ._FormEscritura = blnEscrituraRegistro
                    ._FormEliminar = blnEliminarRegistro
                    ._FormReporte = blnReporteRegistro
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarResoluciones()
                    End If
                End With
            Else
                Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoID = Me.InternoID
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    ._InternoID = Me.InternoID
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._TipoResolucion = TipoResolucion
                    ._blnNuevoRegistro = False
                    'permisos
                    ._FormEscritura = blnEscrituraRegistro
                    ._FormEliminar = blnEliminarRegistro
                    ._FormReporte = blnReporteRegistro
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarResoluciones()
                    End If
                End With
            End If
        End Sub
        Private Sub FRM_Resol_AnulacionAntecedentes(DocJudicialId As Integer, TipoResolucion As Integer)
            Dim frm As New Registro.Sentencias.frmResolAnulacion
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.InternoID
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me.InternoID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub
#End Region

#Region "Movimientos"
        Private Sub FRM_MovimientoTipo(NroPendientes As Integer, strMensaje As String)

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            If ValorIngreso = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) +
                                                            "debe regularizar para poder realizar una operación.")
                Exit Sub
            End If

            If NroPendientes > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Acción no permitida mientras que exista un movimiento con estado: " & strMensaje)
                Exit Sub
            End If

            Dim frm As New Registro.Movimientos.frmMovimientoTipoPopup
            With frm

                ._InternoID = Me.InternoID
                ._IngresoID = Me._IDIngreso
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._NuevoRegistro = True
                ._NroPendientes = NroPendientes
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
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

                Case EnumMovTipo.TrasladoHospitalmental, EnumMovTipo.RetornodeHospitalmental
                    FRM_TrasladoHospitalmental(MovimientoID, MovimientoTipoID, MovimientoTipoID, IngresoID, DocumentoJudID, Pendientes)

                Case Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe Tipo de Movimiento")
            End Select

        End Sub
        Private Sub FMR_MovimientoInternamiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer)
            Dim frm As New Registro.Movimientos.frmMovimientoInternamientoCarceleta
            With frm
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.InternoID
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
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With

        End Sub
        Private Sub FRM_MovimientoTraslado(MovimientoID As Integer, MovimientoTipoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.Movimientos.frmMovimientoTraslado
            With frm
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Traslado
                '._CargarDocumentoJudicial = True
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
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
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Libertad
                ._NroPendientes = Pendientes
                '._CargarExpedientes = True
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
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
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Libertad
                ._CargarExpedientes = True
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
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
                ._Codigo = MovimientoID
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoMovimiento = MovimientoTipoID
                ._TipoLicencia = enmTipoLicencia.PenalLimaProvincia
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
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
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.InternoID
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._CargarDocumento = True
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub


#End Region

#Region "Actualizacion"
        Private Sub FRM_ActualizarSalas()

            Me.Cursor = Cursors.WaitCursor

            Dim frm As New Mantenimiento.frmTablasMaestrasPopup
            With frm
                .ShowDialog()
            End With

            Me.Cursor = Cursors.Default

        End Sub

#End Region

#Region "Clasificacion"
        Private Sub FRM_ClasificacionIndicadores(intTipoFicha As Short, objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.DatosFicha)

            Dim frm As New Registro.Carceleta.Clasificacion.frmDetalleFicha_V2

            With frm
                .VariableId = objEnt.MaeIDVariable
                .FichaId = objEnt.MaeIDFicha
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
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
                            UscFichaClasificacion2._ListarFilaVariable(._ValorPuntaje, .ValorNombreSeleccionado, .ValorIdSeleccionado, ._ValorNoPrevisto)
                    End Select
                End If
            End With

        End Sub
        Private Sub FRM_ReporteClasificacion(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionRegimen.EnmFichaTab)

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me.InternoID
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

            Dim intLicenciaID As Integer = Me.IDLicencia
            Dim bssInstall As New Bussines.Sistema.Instalacion

            Select Case bssInstall.Listar(intLicenciaID).Tipo

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                    value = Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia

                    Dim objBssInDet As New Bussines.Sistema.InstalacionDetalle
                    Dim intLicEscritura As Integer

                    intLicEscritura = objBssInDet.VerificarPermisoEscritura(-1, intLicenciaID, IDPenal)
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
            Dim objBss As New Bussines.Sistema.Instalacion
            intTipoLicencia = objBss.ListarTipo(intLicenciaID)

            blnLecturaRegistro = Permisos._FormLecturaRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            blnEscrituraRegistro = Permisos._FormEscrituraRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            blnEliminarRegistro = Permisos._FormEliminarRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            blnReporteRegistro = Permisos._FormReporteRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)

            'permisos de tratamiento
            Dim blnLecturaTratamiento As Boolean = Permisos._FormLecturaTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            Dim blnEscrituraTratamiento As Boolean = Permisos._FormEscrituraTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            Dim blnReporteTratamiento As Boolean = Permisos._FormReporteTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)

            'controles
            Me.pnlGrabarDatos.Visible = blnEscrituraRegistro
            Me.pnlInactivar.Visible = blnEscrituraRegistro
            Me.pnlEliminar.Visible = blnEliminarRegistro
            Me.pnlReporte.Visible = blnReporteRegistro
            Me.pnlVerLibro.Visible = blnReporteRegistro

            '/*datos complementarios*/
            Me.UscIdiomaInterno1._VisibleGrabar = blnEscrituraRegistro
            Me.UscIdiomaInterno1._VisibleEliminar = blnEliminarRegistro

            Me.UscGradosAcademicos1._VisibleGrabar = blnEscrituraRegistro
            Me.UscGradosAcademicos1._VisibleEliminar = blnEliminarRegistro

            Me.UscDomicilio1._VisibleGrabar = blnEscrituraRegistro
            Me.UscDomicilio1._VisibleEliminar = blnEliminarRegistro

            '/*nombres asociados*/            
            Me.UscGrillaNombresAsociadosV21._VisibleGrabar = blnEscrituraRegistro
            Me.UscGrillaNombresAsociadosV21._VisibleEliminar = blnEliminarRegistro

            'fotografia
            Me.uscFotoPerfiles._VisibleGrabar = blnEscrituraRegistro
            Me.uscFotoPerfiles._VisibleEliminar = blnEliminarRegistro

            '/*alias y bandas*/
            Me.UscAlias21._VisibleGrabar = blnEscrituraRegistro
            Me.UscAlias21._VisibleEliminar = blnEliminarRegistro

            Me.UscBandas21._VisibleGrabar = blnEscrituraRegistro
            Me.UscBandas21._VisibleEliminar = blnEliminarRegistro

            '/*organizacion criminal*/
            Me.UscGrillaBandasV21._VisibleGrabar = blnEscrituraRegistro
            Me.UscGrillaBandasV21._VisibleEliminar = blnEliminarRegistro

            '/*familiares*/
            Me.UscFamilias1._VisibleGrabar = blnEscrituraRegistro
            Me.UscFamilias1._VisibleEliminar = blnEliminarRegistro

            '/*documentos, resoluciones */
            Me.UscResolucionesMain1._VisibleGrabar = blnEscrituraRegistro
            Me.UscResolucionesMain1._VisibleEliminar = blnEliminarRegistro

            '/*movimientos*/
            Me.UscMovimiento1._VisibleGrabar = blnEscrituraRegistro
            Me.UscMovimiento1._VisibleEliminar = blnEliminarRegistro

            Me.UscOdont._VisibleGrabar = blnEscrituraRegistro
            Me.UscOdont._VisibleEliminar = blnEliminarRegistro

            If blnLecturaTratamiento = True And blnLecturaRegistro = True Then
                'nada, perfil osin
            Else
                If blnLecturaTratamiento = True Then
                    'eliminar el tabs de registros
                    Me.TabControl1.TabPages.Remove(Me.tbpResoluciones)
                    Me.tbcDatosInternos.TabPages.Remove(tbpNombresAsoc)
                    Me.tbcDatosInternos.TabPages.Remove(tbpReniec)
                    Me.tbcDatosInternos.TabPages.Remove(tbpAlias)
                    Me.tbcDatosInternos.TabPages.Remove(tbpOrgCriminal)
                    Me.tbcDatosInternos.TabPages.Remove(tbpFamiliares)
                    Me.tbcDatosInternos.TabPages.Remove(tbpOdontograma)
                    Me.tbcDatosInternos.TabPages.Remove(tbpHuella)

                    'pemrisos
                    With Me.UscFichaClasificacion1
                        ._uscEscritura = blnEscrituraTratamiento
                        ._uscReporte = blnReporteTratamiento
                    End With

                    With Me.UscFichaClasificacion2
                        ._uscEscritura = blnEscrituraTratamiento
                        ._uscReporte = blnReporteTratamiento
                    End With

                    With Me.UscPabellon1
                        ._uscEscritura = blnEscrituraTratamiento
                        ._uscReporte = blnReporteTratamiento
                    End With
                Else
                    'eliminar el tabs de tratamiento
                    Me.TabControl1.TabPages.Remove(Me.tbpClasificacion)
                End If
            End If

        End Sub
#End Region
#Region "Reniec"
        Private Sub Nuevo_Validacion_Reniec()
            Dim TipoValidacion As Integer = -1
            Dim intVal2NombreAsocID As Integer = -1

            UscValidacionReniecV21.ListarInternoValidado(Me.InternoID)
            Dim obj As New Entity.Registro.InternoReniec
            obj = ObtenerHistoricoGeoreferencia()
            Dim entIngreso As New Entity.Registro.Ingreso
            objBssIngreso = New Bussines.Registro.Ingreso
            entIngreso = objBssIngreso.ListarUltimoIngreso(Me.InternoID)
            'realizar la validacion de reniec

            Dim frmValidacion As New Registro.Reniec.frmTipoValidacionV2
            With frmValidacion

                ._InternoID = Me.InternoID
                ._NroIngresoID = entIngreso.Codigo
                ._TipoDocumento = Me.TipoDocumento
                ._NumeroDocumento = Me.NumeroDocumento
                ._Estado = Me.InternoEstado

                ._ImagenSis = UscValidacionReniecV21._NumeroImagen
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID

                ._ListaInternoSisCabecera = UscValidacionReniecV21._ListaCabeceraInterno
                ._ListaInternoSisData = UscValidacionReniecV21._ListaDataInterno
                ._NombresAsociados = UscValidacionReniecV21._NombresAsociados

                ._ApellidoPaterno = objEntInt.ApellidoPaterno
                ._ApellidoMaterno = objEntInt.ApellidoMaterno
                ._Nombres = objEntInt.Nombres
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ListarData()
                    DatosPersonalesVerificacionRnc()
                    ActualizarGeoreferencia(obj)
                End If
            End With
            UscValidacionReniecV21.Listar_ReniecHistorico(Me.InternoID)
        End Sub

        Private Function ValidarFichaReniec() As Boolean

            Dim value As Boolean = False

            If Me.InternoID < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInternos.SelectedIndex = 0
                Return value
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Me.tbcDatosInternos.SelectedIndex = 0
                Return value
            End If

            If Me.Nacionalidad <> 141 Then '"nacionalidad peruana"
                Me.tbcDatosInternos.SelectedIndex = 0
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno no posee la nacionalidad peruana")
                Return value
            End If

            '/****************************/
            Dim objBssFoto As New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(InternoID)
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
                Me.tbcDatosInternos.SelectedIndex = 2
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno no puede ser validado porque no cuenta con fotografia, capture la fotografia luego realize la validación")
                Return value
            End If

            value = True

            Return value

        End Function
        Private Function ObtenerHistoricoGeoreferencia() As Entity.Registro.InternoReniec
            Dim obj As New Entity.Registro.InternoReniec
            objBssInternoRnc = New Bussines.Registro.InternoReniec
            obj.InternoID = Me.InternoID
            obj = objBssInternoRnc.ListarGeo(obj)
            If obj Is Nothing Then
                obj = Nothing
            ElseIf obj.Codigo < 1 Then
                obj = Nothing
            End If
            Return obj
        End Function
        Private Sub ActualizarGeoreferencia(obj As Entity.Registro.InternoReniec)
            If obj Is Nothing Then
                Exit Sub
            End If
            If obj.Latitud.Length = 0 And obj.Longitud.Length = 0 Then
                Exit Sub
            End If
            Dim DataHisRnc() As String = obj.ReniecData.Split("|")
            objBssInternoRnc = New Bussines.Registro.InternoReniec
            Dim objRnc As New Entity.Registro.InternoReniec
            objRnc.InternoID = Me.InternoID
            objRnc = objBssInternoRnc.ListarGeo(objRnc)
            Dim DataRnc() As String = objRnc.ReniecData.Split("|")
            If DataHisRnc(10) = DataRnc(10) And DataHisRnc(11).Trim = DataRnc(11).Trim Then
                objRnc.Latitud = obj.Latitud
                objRnc.Longitud = obj.Longitud
                objBssInternoRnc.Grabar(objRnc)
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarControlesAccion()

            Dim blnVisibleActualizarSalas As Boolean = False
            Dim blnVisibleBandas As Boolean = False

            Dim blnVisibleGrabarDatos As Boolean = False
            Dim blnVisibleNuevoReniec As Boolean = False
            Dim blnVisibleEliminarInterno As Boolean = False
            Dim blnVisibleLeyenda As Boolean = False

            Select Case Me.TabControl1.SelectedTab.Name

                Case Me.tbpInterno.Name

                    Select Case Me.tbcDatosInternos.SelectedTab.Name

                        Case Me.tbpDatos.Name   'datos del interno, foto

                            blnVisibleGrabarDatos = blnEscrituraRegistro
                            blnVisibleNuevoReniec = False
                            blnVisibleEliminarInterno = blnEliminarRegistro
                            Me.Panel3.Visible = True

                        Case Me.tbpDatosComplement.Name 'datos complemtarios
                            blnVisibleGrabarDatos = blnEscrituraRegistro

                        Case Me.tbpFoto.Name  'foto

                            blnVisibleGrabarDatos = False
                            blnVisibleNuevoReniec = False
                            blnVisibleEliminarInterno = False
                            Me.Panel3.Visible = False

                        Case Me.tbpReniec.Name  'reniec
                            blnVisibleGrabarDatos = False
                            blnVisibleNuevoReniec = blnEscrituraRegistro
                            blnVisibleEliminarInterno = False
                            Me.Panel3.Visible = False

                        Case Me.tbpOrgCriminal.Name 'bandas
                            blnVisibleBandas = True
                            Me.Panel3.Visible = False
                        Case Else
                            Me.Panel3.Visible = False
                    End Select

                Case Me.tbpResoluciones.Name
                    Me.Panel3.Visible = False
                    Select Case Me.TabControl3.SelectedTab.Name

                        Case Me.tbpListaExpedientes.Name   'mandato detencion, 
                            blnVisibleActualizarSalas = True
                            blnVisibleLeyenda = True

                        Case Me.tbpDocumentos.Name  'resoluciones
                            blnVisibleActualizarSalas = True

                        Case Me.tbpMovimientos.Name 'movimientos
                            blnVisibleActualizarSalas = True
                    End Select
            End Select

            Me.pnlLeyenda.Visible = blnVisibleLeyenda
            Me.pnlGrabarDatos.Visible = blnVisibleGrabarDatos
            Me.pnlNuevoReniec.Visible = blnVisibleNuevoReniec
            Me.pnlEliminar.Visible = blnVisibleEliminarInterno

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
            Me.txtCodigo.BackColor = Control.DefaultBackColor()
            Me.txtInterno.BackColor = Control.DefaultBackColor()
            Me.txtEstado.BackColor = Control.DefaultBackColor()
            Me.txtRegionPenal.BackColor = Control.DefaultBackColor()

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


        Private Sub UscResolucionesMain1__Click_ModificarResolucion(TipoResolucion As System.Int32, DocJudicialId As System.Int32, SubTipo As System.Int32, version As System.String) Handles UscResolucionesMain1._Click_BtnModificarResolucion

            FRM_Resolucion_Sentencia(TipoResolucion, DocJudicialId, SubTipo)

        End Sub
        Private Sub UscResolucionesMain1__Click_BtnVerExpedientesPorResolucion(_NroIngresoID As System.Int32) Handles UscResolucionesMain1._Click_BtnVerExpedientesPorResolucion
            FRM_ListadoExpediente()
        End Sub
        Private Sub UscResolucionesMain1__Click_BtnNuevoResolucion(IngresoID As System.Int32, ResIngRegistrado As Boolean, Opcion As Integer) Handles UscResolucionesMain1._Click_BtnNuevoResolucion

            FRM_ListarResoluciones(IngresoID, ResIngRegistrado, Opcion)

        End Sub

        Private Sub UscMandatoDetencion__CellDoubleClick_GrillaAgraviado(IngresoCodigo As Integer, ExpedienteCodigo As Integer, DelitoCodigo As Integer, AgraviadoCodigo As Integer) Handles UscMandatoDetencion._CellDoubleClick_GrillaAgraviado
            FRM_MantAgraviado(False, IngresoCodigo, ExpedienteCodigo, DelitoCodigo, AgraviadoCodigo)
        End Sub

        Private Sub UscMandatoDetencion__CellDoubleClick_GrillaDelito(IngresoCodigo As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32) Handles UscMandatoDetencion._CellDoubleClick_GrillaDelito
            FRM_MantDelito(False, IngresoCodigo, ExpedienteCodigo, DelitoCodigo)
        End Sub

        Private Sub UscMandatoDetencion__CellDoubleClick_GrillaExpediente(IngresoCodigo As Integer, ExpedienteCodigo As Integer) Handles UscMandatoDetencion._CellDoubleClick_GrillaExpediente
            FRM_MantExpediente(False, IngresoCodigo, ExpedienteCodigo)
        End Sub

        Private Sub frmMantenimiento2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()
            HabilitarControlesAccion()

            'ocultar el boton de inactivar para las regiones
            Dim intTipoLicencia As Short = -1
            Dim objBssLicencia As New Bussines.Sistema.Instalacion

            intTipoLicencia = objBssLicencia.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            If intTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia Then
                Me.btnInactivar.Visible = True
            Else
                Me.btnInactivar.Visible = False
            End If

        End Sub

        Private Sub frmMantenimiento2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            ListarData()

            DatosPersonalesVerificacionRnc()
            Usuario_Permisos()
            If InternoFechaNac > 0 Then
                ActivaDesactivaCheckMenorEdad()
            End If
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
            Select Case Me.tbcDatosInternos.SelectedTab.Name

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

        Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcDatosInternos.SelectedIndexChanged

            Select Case Me.tbcDatosInternos.SelectedTab.Name
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
                Case Me.tbpAlias.Name
                    ListarAlias()
                    ListarBandas()
                Case Me.tbpFamiliares.Name
                    ListarFamilia()
                Case Me.tbpOrgCriminal.Name
                    LoadUscBandas()
                Case Me.tbpReniec.Name
                    DataValidarReniec()
                Case Me.tbpOdontograma.Name
                    LoadUscOdontograma()
                Case Me.tbpHuella.Name
                    LoadUscHuellas()
            End Select

            HabilitarControlesAccion()

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedTab.Name
                Case Me.tbpInterno.Name
                    'ListarData()
                Case Me.tbpResoluciones.Name
                    Listar_Expedientes()

                Case Me.tbpClasificacion.Name
                    ListarClasificacionRegimen()
            End Select

            HabilitarControlesAccion()

        End Sub
        Private Sub cbbAndina__ValueChanged() Handles cbbAndina._SelectedIndexChanged
            If blnComboComAnd = True Then
                ComboComunidadAndinaEspecifico()
            End If
        End Sub
        Private Sub btnActualizarSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            FRM_ActualizarSalas()
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
                Else
                    'txtCodInterno.Focus()
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

        Private Sub cbbNroIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbNroIngresos.SelectedIndexChanged
            If Me.InternoID < 1 Or Me._IDIngreso < 1 Then
                Exit Sub
            End If
            TabControl1_SelectedIndexChanged(sender, e)
            TabControl2_SelectedIndexChanged(sender, e)
            uscFotoPerfiles.DataGrieView_Click()
            TabControl3_SelectedIndexChanged(sender, e)

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            Nuevo_Validacion_Reniec()
        End Sub

        Private Sub UscGrillaNombresAsociados1__UpdNombreAsociado(id As Integer, objEntNA As Entity.Registro.NombreAsociado)
            FRM_Mant_NombresAsociados(False, id, objEntNA)
        End Sub

        Private Sub TabControl3_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl3.SelectedIndexChanged

            HabilitarControlesAccion()

            Select Case Me.TabControl3.SelectedTab.Name

                Case Me.tbpListaExpedientes.Name
                    Listar_Expedientes()
                Case Me.tbpDocumentos.Name
                    ListarResoluciones()
                Case Me.tbpMovimientos.Name
                    ListarMovimientosIngreso()
            End Select

        End Sub

        Private Sub btnFicha_Click(sender As System.Object, e As System.EventArgs) Handles btnFicha.Click
            FRM_VerReportes()
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__AddNombreAsociado() Handles UscGrillaNombresAsociadosV21._AddNombreAsociado

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe Ningun Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            FRM_Resol_AclaratoriaNombres(-1)

        End Sub

        Private Sub UscGrillaNombresAsociadosV21__UpdNombreAsociado(id As System.Int32, objEnt As Entity.Registro.NombreAsociado, forzarRegistroSoloLectura As Boolean) Handles UscGrillaNombresAsociadosV21._UpdNombreAsociado
            FRM_Mant_NombresAsociados(False, id, objEnt)
        End Sub

        Private Sub UscGrillaBandasV21__AddInternoBanda() Handles UscGrillaBandasV21._AddInternoBanda

            FRM_Mant_Siscrico(True)

        End Sub

        Private Sub UscGrillaBandasV21__UpdInternoBanda() Handles UscGrillaBandasV21._UpdInternoBanda
            FRM_Mant_Siscrico(False)
        End Sub

        Private Sub UscGrillaBandasV21__AnularInternoBanda() Handles UscGrillaBandasV21._AnularInternoBanda
            If UscGrillaBandasV21.GrillaEstadoId = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "No es posible completar la operación, registro ya se encuentra anulado")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Confirma cambiar el estado del registro seleccionado a ANULADO?") = MsgBoxResult.Yes Then
                AnularInternoBanda()
            End If

        End Sub

        Private Sub btnAddIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnAddIngreso.Click
            Me.NuevoClickfrmIngreso = False
            FRM_ListaIngreso()
        End Sub

        Private Sub uscFotoPerfiles__Clik_MantenimientoFotos(InternoFotId As System.Int32, RestringirEdicion As Boolean) Handles uscFotoPerfiles._Clik_MantFotos

            FRM_Mant_Fotos(InternoFotId, RestringirEdicion)

        End Sub

        Private Sub btnEliminarIngreso_Click(sender As System.Object, e As System.EventArgs)

            FRM_ListaIngreso()

        End Sub


        Private Sub UscMovimiento1__CellDoubleClick_UpdateMovimiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer, IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer) Handles UscMovimiento1._CellDoubleClick_UpdateMovimiento

            FRM_Movimiento(MovimientoID, MovimientoGrupoID, MovimientoTipoID, MovimientoMotivoID, IngresoID, DocumentoJudID, Pendientes)

        End Sub

        Private Sub UscMovimiento1__Click_AddNuevoMovimiento(NroPendientes As Integer, strMensaje As String) Handles UscMovimiento1._Click_AddNuevoMovimiento

            FRM_MovimientoTipo(NroPendientes, strMensaje)

        End Sub

        Private Sub UscMovimiento1__Click_EliminarMovimiento() Handles UscMovimiento1._Click_EliminarMovimiento

            Me.UscMovimiento1._Listar()
            ListarCabecera()

        End Sub

        Private Sub uscFotoPerfiles__Clik_MantRasgos(RasgoId As System.Int32) Handles uscFotoPerfiles._Clik_MantRasgos
            FRM_Mant_Rasgo(RasgoId)
        End Sub

        Private Sub uscFotoPerfiles__Clik_MantSeniaPart(SenPartId As System.Int32) Handles uscFotoPerfiles._Clik_MantSeniaPart
            FRM_Mant_SeniaParticular(SenPartId)
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnEliminarActualizarEstadoInterno() Handles UscResolucionesMain1._Click_BtnEliminarActualizarEstadoInterno

            ListarCabecera()
            ListarData()
            UscGrillaNombresAsociadosV21._LoadUsc()

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

        Private Sub UscMovimiento1__ClickFocusCombo() Handles UscMovimiento1._ClickFocusCombo
            Me.cbbNroIngresos.Focus()
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
            Me.NuevoClickfrmIngreso = True
            FRM_ListaIngreso()
            'ValidacionTemporal()
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__MostrarResolucionesAclarados() Handles UscGrillaNombresAsociadosV21._MostrarResolucionesAclarados
            UscResolucionesMain1._ChekedValor = True
            TabControl1.SelectedIndex = 1
            TabControl3.SelectedIndex = 1
        End Sub

        Private Sub UscBandas21__DoubleClikBandas(Nuevo As System.Boolean, AliasID As System.Int32, IngresoID As System.Int32, BandentCol As Entity.Registro.InternoBandaCol) Handles UscBandas21._DoubleClikBandas
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

        Private Sub UscAlias21__ClickAdd() Handles UscAlias21._ClickAdd
            FRM_MantenimientoAlias(True, -1, Me._IDIngreso)
        End Sub

        Private Sub UscAlias21__ClickMod(AliasID As System.Int32, IngresoID As System.Int32, forzarRegistroSoloLectura As Boolean) Handles UscAlias21._ClickMod
            FRM_MantenimientoAlias(False, AliasID, IngresoID)
        End Sub

        Private Sub UscAlias21__DoubleClick(AliasID As Integer, IngresoID As Integer, forzarRegistroSoloLectura As Boolean) Handles UscAlias21._DoubleClick
            UscAlias21__ClickMod(AliasID, IngresoID, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscFamilias1__CellDoubleClick(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._CellDoubleClick
            UscFamilias1__ClickModificar1(IDFamilia, objEntFamCol, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscFamilias1__ClickAdd(objEntFamCol As Entity.Registro.FamiliarCol) Handles UscFamilias1._ClickAdd
            FRM_Mant_Familia(True, -1, objEntFamCol)
        End Sub

        Private Sub UscFamilias1__ClickModificar1(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._ClickModificar
            FRM_Mant_Familia(False, IDFamilia, objEntFamCol)
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

            If blnModificarDatos = True Then
                If MessageBox.Show("¿Desea guardar los datos del interno?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    blnModificarDatos = False
                    EnabledControles(True)
                Else
                    e.Cancel = True
                End If
            End If

        End Sub

        Private Sub UscGrillaNombresAsociadosV21__AnularNombreAsociado() Handles UscGrillaNombresAsociadosV21._AnularNombreAsociado
            LoadUscNombresAsociados()
        End Sub

        Private Sub btnActivar_Click(sender As System.Object, e As System.EventArgs)
            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de realizar una operacion, grabe los datos basicos del interno.")
            ElseIf Me.InternoEstado = Type.Enumeracion.Interno.EnmEstado.Activo Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno ya se encuentra en estado ACTIVO")
            Else
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Esta seguro de actualizar el estado del interno a estado ACTIVO") = DialogResult.Yes Then
                    objBssInterno = New Bussines.Registro.Interno
                    objBssInterno.ActivarEstado(Me.InternoID)
                    Me.InternoEstado = Type.Enumeracion.Interno.EnmEstado.Activo
                    ListarCabecera()
                End If
            End If
        End Sub

        Private Sub btnInactivar_Click_1(sender As Object, e As EventArgs) Handles btnInactivar.Click

            Dim strTitulo As String = "Regularizacion de Internos Pasivos"

            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de realizar una operacion, grabe los datos basicos del interno.", strTitulo)

            ElseIf Me.InternoEstado = Type.Enumeracion.Interno.EnmEstado.Inactivo Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno ya se encuentra en estado INACTIVO", strTitulo)
            Else

                If MessageBox.Show("Esta seguro de actualizar el estado del interno a estado INACTIVO", strTitulo, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.Yes Then

                    objBssInterno = New Bussines.Registro.Interno
                    objBssInterno.ActualizarEstadoBaja(Me.InternoID)
                    Me.InternoEstado = Type.Enumeracion.Interno.EnmEstado.Inactivo
                    ListarCabecera()
                End If

            End If

        End Sub

        Private Sub btnVerLibros_Click(sender As Object, e As EventArgs) Handles btnVerLibros.Click
            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no ha sido grabado")
                Exit Sub
            End If

            Dim frm As New Registro.RegionLima.Resoluciones.frmListarLibros
            frm._InternoID = Me.InternoID
            frm._LicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
            frm.ShowDialog()
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

                Case Me.tpPabellon.Name
                    ListarPabellonUbicacion()
            End Select

        End Sub

        Private Sub UscFichaClasificacion2__GrillaFichaVariable_CellClick(objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.DatosFicha) Handles UscFichaClasificacion2.GrillaFichaVariable_CellClick

            FRM_ClasificacionIndicadores(2, objEnt)

        End Sub

        Private Sub UscFichaClasificacion1__GrillaFicha_CellEnter(intCodigo As Integer, TipoTablaAudit As Enumeracion.Auditoria.EnumTipTabla) Handles UscFichaClasificacion1.GrillaFicha_CellEnter
            Me.UscAuditUser1.LoadAudit(intCodigo, TipoTablaAudit)
        End Sub

        Private Sub UscPabellon1__Grilla_CellEnter(intCodigo As Integer, TipoTablaAudit As Enumeracion.Auditoria.EnumTipTabla) Handles UscPabellon1._Grilla_CellEnter

            Me.UscAuditUser1.LoadAudit(intCodigo, TipoTablaAudit)

        End Sub

        Private Sub UscFichaClasificacion1__Reporte_Click(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionRegimen.EnmFichaTab) Handles UscFichaClasificacion1.Reporte_Click

            FRM_ReporteClasificacion(intIDInternoFichaFinal, objFichaTab)

        End Sub

        Private Sub UscFichaClasificacion2__Reporte_Click(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionRegimen.EnmFichaTab) Handles UscFichaClasificacion2.Reporte_Click

            FRM_ReporteClasificacion(intIDInternoFichaFinal, objFichaTab)

        End Sub

        Private Sub UscPabellon1__Reporte_Click(intIDFichaFinalEtapa As Integer) Handles UscPabellon1._Reporte_Click

            FRM_ReporteClasificacion(intIDFichaFinalEtapa, -1)

        End Sub

        Private Sub btnDelitosHistoricos_Click(sender As Object, e As EventArgs) Handles btnDelitosHistoricos.Click
            ListarDelitosMayorPena()
        End Sub
        Private Sub ListarDelitosMayorPena()
            Dim frm As New Registro.frmListaDelitosHistoricos
            frm._InternoID = Me.InternoID
            frm.ShowDialog()
        End Sub

    End Class
End Namespace
