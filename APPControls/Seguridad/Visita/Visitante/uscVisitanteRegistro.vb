Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Bussines.Globall
Imports Entity

Namespace Visita.Visitante
    Public Class uscVisitanteRegistro
        Private objBssVis As Bussines.Visita.Visitante = Nothing
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
        Private objEnt_Temporal_Visitante As Entity.Visita.Visitante = Nothing

        Private frmLoad As Load.frmLoad02 = Nothing
        Private objVisitanteReniec As Bussines.Visita.VisitanteReniec.objDTOPersona = Nothing
        Private objVisitanteMigraciones As APPWebService.Result.ConsultarExtranjero = Nothing

        Private blnGrabarValServicioVisNuevo As Boolean = False
        Private blnGrabarVisAdmin As Boolean = False

#Region "Eventos"
        Public Event _Click_BuscarMenores()
        Public Event _Click_ListarData()
        Public Event _Click_BuscarVisita()
        Public Event _SelectedIndexChanged_TipoDocumento(intIDTipoDocumento As Short)
#End Region
#Region "Propiedades_Parametricas"
        Public Property objTipoVisita As Type.Enumeracion.Visita.EnumTipo = Type.Enumeracion.Visita.EnumTipo.Ninguno
        Public Property _RegionID() As Integer = -1
        Public Property _RegionNombre() As String = ""
        Public Property _PenalID() As Integer = -1
        Public Property _PenalNombre() As String = ""
        Public Property _FechaVisita() As Long = 0

        '/*tabla de configuracion del modulo de visita*/
        Public Property _TipoVisita() As Type.Enumeracion.Visita.EnumTipo
            Get
                Return objTipoVisita
            End Get
            Set(ByVal value As Type.Enumeracion.Visita.EnumTipo)
                objTipoVisita = value
            End Set
        End Property

        Public Property _RegimenTipoID As Short = -1
        Public Property _SolicitarAutoRegOrdinario As Boolean = False
        Public Property _ValidarFechaNacimiento As Boolean = False
        Public Property _HabilitarHuellaDigital As Boolean = False
        Public Property _HabilitarCapHuellaValReniec As Boolean = False
        Public Property _mostrarTipoDocumentosValidos As Boolean = False
        'reniec
        Public Property _ValidarModuloVisConReniec As Boolean = False
        Public Property _ValidarVisitanteConReniec As Boolean = False
        'migraciones
        Public Property _ValidarModuloVisConMigraciones As Boolean = False
        Public Property _ValidarVisitanteConMigraciones As Boolean = False

#End Region
#Region "Propiedades_Return"
        Public ReadOnly Property _VisitanteIDReturn() As Integer
            Get
                Return Me.IDVisitante
            End Get
        End Property
        Public ReadOnly Property _IDTipoDocumento As Short
            Get
                Return Me.TipoDocumentoID
            End Get
        End Property
        Public ReadOnly Property _TipoDocumentoNombre() As String
            Get
                Return Me.cbbTipoDoc.Text
            End Get
        End Property
        Public ReadOnly Property _NumeroDocumento() As String
            Get
                Return Me.NumeroDocumento
            End Get
        End Property
        Public ReadOnly Property _PrimerApellido() As String
            Get
                Return Me.ApellidoPaterno
            End Get
        End Property
        Public ReadOnly Property _SegundoApellido() As String
            Get
                Return Me.ApellidoMaterno
            End Get
        End Property
        Public ReadOnly Property _PreNombres() As String
            Get
                Return Me.Nombres
            End Get
        End Property
        Public ReadOnly Property _ApellidosyNombres() As String
            Get
                Return Me.ApelidosyNombres
            End Get
        End Property
        Public ReadOnly Property _PaseNumero() As String
            Get
                Return Me.PaseNumero
            End Get
        End Property
        Public ReadOnly Property _Sancion() As Boolean
            Get
                Return Me.VisitaSancion
            End Get
        End Property
        Public ReadOnly Property _SexoID() As Integer
            Get
                Return Me.SexoID
            End Get
        End Property
        Public ReadOnly Property _Sexo() As String
            Get
                Return Me.Sexo
            End Get
        End Property
        Public ReadOnly Property _IsVisitanteNuevo As Boolean
            Get
                Return Me.VisitanteNuevo
            End Get
        End Property
        Public ReadOnly Property _ConcatenarPropiedadesVisitante As String
            Get
                Return Me.ConcatenarPropiedadesVisitante
            End Get
        End Property
        Public ReadOnly Property _FechaNacimiento As Long
            Get
                Return Me.FechaNacimiento
            End Get
        End Property
        Public ReadOnly Property _VisitanteValidadoReniec As Short
            Get
                Return Me.VisitaValidadoServicio
            End Get
        End Property
        Public Property _VisitanteIngresaPor As Short = Type.Enumeracion.Visita.Movimiento.IngresoPor.Ninguno
        Public Property _VisitanteNumeroRecaptura As Short = 0
#End Region
#Region "Propiedades"
        Private Property VisitanteNuevo As Boolean = False
        Private Property IDVisitante() As Integer = -1
        Private Property TipoDocumentoID() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
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
        Private ReadOnly Property ApelidosyNombres() As String
            Get
                Dim strValue As String = ""
                strValue = Me.ApellidoPaterno & " " & Me.ApellidoMaterno & ", " & Me.Nombres

                Return strValue
            End Get
        End Property
        Private Property IDNacionalidad() As Integer
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property SexoID() As Integer
            Get
                Return Me.CbbSexo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.CbbSexo.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property Sexo() As String
            Get
                Dim value As String = ""
                Select Case Me.SexoID
                    Case 1
                        value = "Masculino"
                    Case 2
                        value = "Femenino"
                End Select
                Return value
            End Get
        End Property
        Private Property FechaNacimiento() As Long
            Get
                Return Me.dtpFechaNac.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaNac.ValueLong = value
            End Set
        End Property
        Private Property FotoID() As Integer = -1
        Private Property FotoName As String = ""
        Private Property VisitaTieneHuella As Short = Type.Enumeracion.Visita.Visitante.TieneHuella.Ninguno
        Private Property VisitaValidadoServicio As Short = Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar
#End Region
#Region "Propiedades_Otros"
        Private Property VisitaSancion() As Boolean
            Get
                Return Me.UscFotografia1._PanelAutorizacion
            End Get
            Set(ByVal value As Boolean)
                Me.UscFotografia1._PanelAutorizacion = value
            End Set
        End Property
        Private Property PaseNumero() As String
            Get
                Return Me.txtPaseNumero.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtPaseNumero.Text = value
            End Set
        End Property

#End Region
#Region "Funciones_Publicas"
        Public Sub _visibleCampoPase(value As Boolean)

            Me.txtPaseNumero.Visible = value
            Me.lblCampoPase.Visible = value

            If value = False Then
                Me.cbbTipoDoc.Location = New Point(109, cbbTipoDoc.Location.Y)
                Me.cbbTipoDoc.Width = 218
                Me.cbbTipoDoc.Refresh()
            End If

        End Sub
#End Region
#Region "Combo"
        Private Sub ComboDocumentoTipo(soloDocumentosValidos As Boolean)

            '/*tipo documento*/
            With Me.cbbTipoDoc
                .ComboTipo = Type.Combo.ComboTipo.TipoDoc

                If soloDocumentosValidos = True Then

                    Dim lista As New List(Of Integer)
                    lista.Add(Type.Enumeracion.enmTipoDocumento.LM) 'L.M. (Libreta Militar)
                    lista.Add(Type.Enumeracion.enmTipoDocumento.PN) 'P.N. (Partida de Nacimiento)
                    lista.Add(8) 'P.N. (CARNE IDENTIDAD PERSONAL)
                    lista.Add(11) 'INDOCUMENTADO
                    lista.Add(Type.Enumeracion.enmTipoDocumento.CC) 'CREDENCIAL CONSULAR
                    lista.Add(14) 'CARNET FISCALIA
                    lista.Add(15) 'CEDULA DE IDENTIDAD

                    .ListaIdsParaExcluir = lista
                End If
                .Parametro1 = 1
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboOtros()

            Me.cbbNacionalidad.ComboTipo = Type.Combo.ComboTipo.Nacionalidad
            Me.cbbNacionalidad.LoadUsc()

            Me.CbbSexo.ComboTipo = Type.Combo.ComboTipo.Sexo
            Me.CbbSexo.LoadUsc()

        End Sub
#End Region
#Region "Validar"
        Private Function ValidarVisita(ByVal ValidarVisitanteID As Boolean, GrabarFotoVisitante As Boolean) As Boolean

            Dim value As Boolean = False

            'codigo
            If ValidarVisitanteID = True Then
                If Me.IDVisitante < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "No se ha registrado los datos del visitante, verifique")
                    Return value
                End If
            End If

            'numero documento
            If Me.NumeroDocumento.Trim = "" Or Me.NumeroDocumento.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese el numero de documento validó, del visitante")
                Me.txtNumDoc.Focus()
                Return value
            End If

            If Me.NumeroDocumento.Trim.Length > 0 Then
                'validar tipo documento y numero
                Select Case Me.TipoDocumentoID
                    Case Is < 1
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Seleccione el tipo de documento")
                        Me.txtNumDoc.Focus()
                        Return value
                    Case 10 'dni
                        If Me.NumeroDocumento.Length <> 8 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "Ingrese el numero de documento, el numero debe contener 8 digitos")
                            Me.txtNumDoc.Focus()
                            Return value
                        End If
                End Select
            End If

            'apellido paterno
            If Me.ApellidoPaterno.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese el apellido paterno del visitante")
                Me.txtApePat.Focus()
                Return value
            End If

            'apellido(materno), si la reniec es falso valida
            If Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar Then

                If Me.ApellidoMaterno = "" Or Me.ApellidoMaterno.Length < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese el apellido materno del visitante")
                    Me.txtApeMat.Focus()
                    Return value
                End If

            End If

            'nombres
            If Me.Nombres.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese los nombres del visitante")
                Me.txtNom.Focus()
                Return value
            End If

            'sexo
            If ValidarSexo() = False Then
                Return value
            End If

            'fecha nacimiento
            If GrabarFotoVisitante = False Then
                If Me._ValidarFechaNacimiento = True Then

                    If Me.FechaNacimiento < 1 Then

                        Dim blnMostrarMensaje1 As Boolean = False
                        Dim blnMostrarMensaje2 As Boolean = False

                        Select Case Me._RegimenTipoID
                            Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario

                                If Me._SolicitarAutoRegOrdinario = True Then
                                    blnMostrarMensaje1 = True
                                Else
                                    blnMostrarMensaje2 = True
                                End If

                            Case Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial

                                blnMostrarMensaje1 = True

                            Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario_RegimenCerradoEspecial

                                If Me._SolicitarAutoRegOrdinario = True Then
                                    blnMostrarMensaje1 = True
                                Else
                                    blnMostrarMensaje2 = True
                                End If

                            Case Else 'administrativo
                                blnMostrarMensaje2 = True
                                If Me.pnlDatosVisitante.Enabled = False Then
                                    blnMostrarMensaje2 = False
                                End If
                        End Select


                        If blnMostrarMensaje1 = True Then
                            Legolas.Configuration.Aplication.MessageBox.Information("Falta regularizar la fecha de nacimiento del Visitante. Coordiné con el Encargado de Control de Visitas")
                            value = True
                            Return value
                        End If

                        If blnMostrarMensaje2 = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha nacimiento del visitante")
                            Me.dtpFechaNac.Focus()
                            Return value
                        End If

                    End If

                End If
            End If

            'fecha de nacimiento, si hay un valor en la fecha de nacimiento
            If Me.FechaNacimiento > 1 Then

                If ValidarMayorEdad() = False Then
                    Me.dtpFechaNac.Focus()
                    Return value
                End If
            End If

            value = True
            Return value

        End Function
        Private Function ValidarSexo() As Boolean

            Dim value As Boolean = False

            'sexo
            If Me.SexoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Seleccione el sexo del visitante")
                Me.CbbSexo.Focus()
                Return value
            End If

            value = True
            Return value

        End Function

        Private Function ValidarIngresoVisitante() As Boolean

            Dim value As Boolean = False

            objBssMov = New Bussines.Visita.Movimiento

            If objBssMov.ValidarDobleIngresoVisitante(Me.IDVisitante, Me._FechaVisita,
                                                     Me._RegionID, Me._PenalID) = True Then

                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "El visitante que desea registrar ya se encuentra dentro del establecimiento")
                Return value
            End If
            value = True

            Return value
        End Function

        Public Function _ValidarIngresoVisitante() As Boolean

            Return ValidarIngresoVisitante()

        End Function
        Private Function ValidarMayorEdad() As Boolean

            Dim value As Boolean = False

            If Me.FechaNacimiento > 0 Then
                If Legolas.Components.FechaHora.FechaCalcularAnio(Me.FechaNacimiento, Me._FechaVisita, True) < 18 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "El visitante es menor de edad, debe estar registrado en la " &
                        "opcion menores de edad. No se puede continuar con el proceso")
                    Return value
                End If

            End If

            value = True
            Return value

        End Function
        Public Function _ValidarMayorEdad() As Boolean
            Return ValidarMayorEdad()
        End Function
        Public Function _ValidarNumeroPase() As Boolean

            Dim value As Boolean = False

            'para validar debe haber minimo un dato
            If Me.PaseNumero.Length > 0 Then

                objBssMov = New Bussines.Visita.Movimiento

                If objBssMov.ValidarNumeroPase(Me.PaseNumero, Me._FechaVisita,
                                                Me._RegionID, Me._PenalID) = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El numero de pase esta asignado a otra persona")
                    Return value
                End If
            End If

            value = True

            Return value

        End Function
        Private Function ValidarTieneRestriccionVisitante() As Boolean

            Dim value As Boolean = False

            If Me.IDVisitante > 0 Then

                Dim objEntFiltro As New Entity.Visita.VisitanteRestriccion
                With objEntFiltro
                    .VisitanteID = Me.IDVisitante
                    .RestriccionTipoID = 2 'restriccion al penal
                    .FechaInicio = Legolas.Configuration.Aplication.FechayHora.FechaLong
                End With

                Dim objBss As New Bussines.Visita.VisitanteRestriccion
                value = objBss.ValidarTieneRestriccionVisitante(objEntFiltro)

                If value = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El visitante tiene restriccion al establecimiento penitenciario")
                End If

            End If

            Return value

        End Function
        Public Function _ValidarVisitante() As Boolean

            Dim value As Boolean = False

            'numero de pase
            If _ValidarNumeroPase() = False Then
                Return value
            End If

            'si el visitante esta adentro
            If ValidarIngresoVisitante() = False Then
                Return value
            End If

            'validar los datos de la visita 
            If ValidarVisita(True, False) = False Then
                Return value
            End If

            value = True
            Return value

        End Function
#End Region
#Region "Listar"
        Private Function ListarVisitante(intIDTipoDocumento As Short, ByVal strNumeroDoc As String) As Boolean

            Dim value As Boolean = False

            objBssVis = New Bussines.Visita.Visitante
            Dim objEntCol As New Entity.Visita.VisitanteCol

            objEntCol = objBssVis.ListarxNumeroDocumento(intIDTipoDocumento, strNumeroDoc, Me._RegionID, Me._PenalID)

            If objEntCol.Count > 0 Then

                For Each ent As Entity.Visita.Visitante In objEntCol
                    'queda
                    If ent.PenalID = Me._PenalID And ent.TipoDocumentoID = Me.TipoDocumentoID Then
                        ListarVisitanteData(ent.Codigo)
                        value = True
                        Exit For
                    End If
                Next
            End If

            Return value

        End Function
        Private Sub ListarVisitanteData(ByVal VisitanteID As Integer)

            If VisitanteID < 1 Then
                Exit Sub
            End If

            objBssVis = New Bussines.Visita.Visitante
            Dim objEnt As Entity.Visita.Visitante

            objEnt = objBssVis.Listar(VisitanteID)

            With objEnt
                Me.IDVisitante = .Codigo
                Me.TipoDocumentoID = .TipoDocumentoID
                Me.NumeroDocumento = .NumeroDocumento
                Me.ApellidoPaterno = .ApellidoPaterno
                Me.ApellidoMaterno = .ApellidoMaterno
                Me.Nombres = .Nombres
                Me.IDNacionalidad = .NacionalidadID
                Me.SexoID = .SexoID
                Me.FotoID = .FotoID
                Me.FotoName = .FotoName
                Me.FechaNacimiento = .FechaNacimiento

                '/*datos de la huella*/
                Me.VisitaTieneHuella = .VisitanteTieneHuella
                Me.VisitaValidadoServicio = .VisitanteValidoReniec

                MostrarHuellaObs()
                LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)

                ImagenFotoVisitante(Me.FotoName)
                ListarSancionVisitante(Me.IDVisitante, Me._FechaVisita)

            End With

            'bloquear datos del visitante
            Dim blnEnabledVisitante As Boolean = False

            If Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado Or Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado Then
                'no se puede modificar x nadie
            Else

                If Me._TipoVisita = Type.Enumeracion.Visita.EnumTipo.Aministrativa Then

                    If Me._SolicitarAutoRegOrdinario = False Then 'no es obligatorio que esten registrados en el regiemn cerrado
                        blnEnabledVisitante = True
                    End If

                End If

            End If

            HabilitarTipoyNumeroDocumento(False)
            HabilitarDatosVisitante(blnEnabledVisitante)

        End Sub
        Private Sub ListarSancionVisitante(ByVal VisitanteID As Integer, ByVal FechaVisita As Long)

            If Me.IDVisitante < 1 Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Visita.VisitanteSancion
            Me.VisitaSancion = objBss.Sancion(VisitanteID, FechaVisita)

        End Sub
        Private Async Sub BuscarProceso()

            If Me.IDVisitante > 0 Then

                'validar que el visitante no sea menor de edad
                If ValidarMayorEdad() = False Then

                    Dim blnDetenerProceso As Boolean = False

                    Select Case Me._TipoVisita
                        Case Type.Enumeracion.Visita.EnumTipo.Aministrativa
                            blnDetenerProceso = True
                        Case Type.Enumeracion.Visita.EnumTipo.Penal

                            Select Case Me._RegimenTipoID
                                Case -1, 1, 3 'ordinario , mixto
                                    blnDetenerProceso = True
                            End Select

                    End Select

                    If blnDetenerProceso = True Then

                        If Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado Or Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado Then
                            'no se puede modificar x nadie
                            HabilitarDatosVisitante(False)
                        Else
                            HabilitarDatosVisitante(Not _SolicitarAutoRegOrdinario)
                        End If

                        'si es menor de edad y no se puede modificar los datos del visitante, se limpia los datos
                        If (Not _SolicitarAutoRegOrdinario) = False Then
                            ALimpiarVisitante(True)
                            Me.txtPaseNumero.Focus()
                        Else
                            Me.dtpFechaNac.Focus()
                        End If

                        Exit Sub
                    End If
                    'Select Case Me._RegimenTipoID
                    '    Case 1, 3 'ordinario , mixto
                    '        HabilitarDatosVisitante(Not _SolicitarAutoRegOrdinario)
                    '        Me.dtpFechaNac.Focus()
                    '        Exit Sub
                    'End Select
                End If
            End If
            'validar numero pase
            If _ValidarNumeroPase() = False Then
                ALimpiarVisitante(True)
                Me.txtPaseNumero.Focus()
                Exit Sub
            End If

            'validar si el visitante ya esta adentro
            If ValidarIngresoVisitante() = False Then
                ALimpiarVisitante(True)
                Me.txtNumDoc.Focus()
                Exit Sub
            End If

            'validar si el visitante, si tiene retriccion
            If ValidarTieneRestriccionVisitante() = True Then
                Exit Sub
            End If

            '/*si tiene sancion*/
            If VisitaSancion = True Then
                Form_DetalleSancion(1)
                Exit Sub
            End If

            'validar foto del visitante
            If Me.FotoName.Trim = "" Then
                FRM_Foto()
            End If

            Dim strMensaje As String = ""
            Dim intMostrarTipoMensaje As Short = 1

            Select Case TipoDocumentoID

                Case Type.Enumeracion.enmTipoDocumento.DNI
                    'validar visitante peruano con la bd de reniec
                    If Await FRM_ValidarVisitaReniecApi(strMensaje, intMostrarTipoMensaje) = False Then

                        Select Case _intMostrarTipoMensaje
                            Case -1
                                Legolas.Configuration.Aplication.MessageBox.MensajeError(_strMensaje)
                            Case 0
                                'nada
                            Case 1
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        End Select

                        ALimpiarVisitante(True)
                        Me.txtPaseNumero.Focus()
                        Exit Sub
                    End If

                Case Type.Enumeracion.enmTipoDocumento.CE, Type.Enumeracion.enmTipoDocumento.PTP, Type.Enumeracion.enmTipoDocumento.CPP

                    'validar visitante extranjetos con la bd de migraciones                    
                    If FRM_ValidarVisitaMigraciones(strMensaje, intMostrarTipoMensaje) = False Then

                        Select Case intMostrarTipoMensaje
                            Case -1
                                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensaje)
                            Case 0
                        '       nada
                            Case 1
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        End Select

                        ALimpiarVisitante(True)
                        Me.txtPaseNumero.Focus()
                        Exit Sub
                    End If
                Case Else

            End Select
            'validar la captura de huella biometrica de la visita
            If FRM_CapturarVerificarHuella(strMensaje) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                ALimpiarVisitante(True)
                Me.txtPaseNumero.Focus()
                Exit Sub
            End If

            If Me.ApellidoPaterno.Length < 2 Then
                Me.txtApePat.Focus()
            Else
                RaiseEvent _Click_ListarData()
            End If

        End Sub

        Dim strMensaje As String = ""
        Dim intMostrarTipoMensaje As Short = 1
        Private Async Sub Buscar()

            ALimpiarVisitante()

            'validar penal
            If Me._PenalID < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Parametro Penal")
                Exit Sub
            End If

            'validar tipo documento y numero
            Select Case Me.TipoDocumentoID
                Case Is < 1
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Seleccione el tipo de documento")
                    Me.txtNumDoc.Focus()
                    Exit Sub
                Case 10 'dni
                    If Me.NumeroDocumento.Length <> 8 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el numero de documento, el numero debe contener 8 digitos")
                        Me.txtNumDoc.Focus()
                        Exit Sub
                    End If
                Case 3, 16, 17 'CE, PTP,CPP
                    If Me.NumeroDocumento.Length <> 9 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el numero de documento, el numero debe contener 9 digitos")
                        Me.txtNumDoc.Focus()
                        Exit Sub
                    End If
            End Select

            '/************/
            Dim blnSigueProceso As Boolean = True
            Dim blnExisteVisitante As Boolean = False

            blnExisteVisitante = ListarVisitante(Me.TipoDocumentoID, Me.NumeroDocumento)

            Me.btnGrabarVisitante.Enabled = True

            If blnExisteVisitante = False Then
                Me._SolicitarAutoRegOrdinario = False
                If Me._SolicitarAutoRegOrdinario = True And _TipoVisita = Type.Enumeracion.Visita.EnumTipo.Penal Then

                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El visitante no esta registrado en el sistema")
                    blnSigueProceso = False
                    ALimpiarVisitante(True)
                    Me.txtPaseNumero.Focus()
                Else

                    If MessageBox.Show("El visitante no existe, desea agregarlo",
                                       Legolas.Configuration.Aplication.MessageBox.MensajeTitulo,
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                        'numero documento
                        If Me.NumeroDocumento.Trim = "" Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "Ingrese el numero de documento del visitante")
                            Me.txtNumDoc.Focus()
                            Exit Sub
                        End If

                        blnGrabarVisAdmin = True
                        HabilitarTipoyNumeroDocumento(False)
                        Dim blnFocusPase As Boolean = False

                        'validar visitante con reniec o migraciones
                        Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar

                        Select Case TipoDocumentoID

                            Case Type.Enumeracion.enmTipoDocumento.DNI

                                'validar modulo reniec
                                If Me._ValidarModuloVisConReniec = True Then

                                    If Await FRM_ValidarVisitaReniecApi(strMensaje, intMostrarTipoMensaje) = False Then

                                        Select Case intMostrarTipoMensaje
                                            Case -1
                                                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensaje)
                                            Case 0
                                            'nada
                                            Case 1
                                                Legolas.Configuration.Aplication.MessageBox.Exclamation(_strMensaje)
                                        End Select

                                        ALimpiarVisitante(True)
                                        Me.txtPaseNumero.Focus()
                                        Exit Sub
                                    Else

                                        If intMostrarTipoMensaje = 1 Then 'todo esta ok

                                            blnGrabarValServicioVisNuevo = True
                                            Me.btnGrabarVisitante.PerformClick() 'salir del proceso actual, xq x el otro interno se hace lo mismo
                                            Exit Sub

                                        End If
                                    End If
                                End If

                            Case Type.Enumeracion.enmTipoDocumento.CE, Type.Enumeracion.enmTipoDocumento.PTP, Type.Enumeracion.enmTipoDocumento.CPP
                                Me._ValidarModuloVisConMigraciones = True
                                'valdidar modulo migraciones
                                If Me._ValidarModuloVisConMigraciones = True Then

                                    If FRM_ValidarVisitaMigraciones(strMensaje, intMostrarTipoMensaje) = False Then

                                        Select Case intMostrarTipoMensaje
                                            Case -1
                                                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensaje)
                                            Case 0
                                            'nada
                                            Case 1
                                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                                        End Select

                                        ALimpiarVisitante(True)
                                        Me.txtPaseNumero.Focus()
                                        Exit Sub
                                    Else

                                        If intMostrarTipoMensaje = 1 Then 'todo esta ok

                                            blnGrabarValServicioVisNuevo = True
                                            Me.btnGrabarVisitante.PerformClick() 'salir del proceso actual, xq x el otro interno se hace lo mismo
                                            Exit Sub

                                        End If
                                    End If

                                End If
                        End Select

                        If Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado Or
                            Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado Then

                            'no se puede modificar x nadie
                            HabilitarDatosVisitante(False)
                        Else
                            HabilitarDatosVisitante(True)

                            If blnFocusPase = True Then
                                Me.txtPaseNumero.Focus()
                            Else
                                Me.txtApePat.Focus()
                            End If

                        End If

                        blnSigueProceso = False

                    Else
                        ALimpiarVisitante(True)
                        Me.txtPaseNumero.Focus()
                        blnSigueProceso = False
                    End If

                End If

            Else

                'si existe el visitante ya no se puede modificar siempre y cuando el parametro de "permitir registrar priamente al regimen ordinario" este activo
                If Me._SolicitarAutoRegOrdinario = True Then
                    'no se puede modificar los datos
                    HabilitarDatosVisitante(False)
                End If
                HabilitarMensaje(Type.Enumeracion.Visita.Visitante.Focus.Ninguno)
            End If

            If blnSigueProceso = True Then
                BuscarProceso()
            End If

        End Sub
#End Region
#Region "Accion"
        Private Function AGrabarVisitante(ByVal ValidarVisitanteID As Boolean, ByVal MensajeGrabar As Boolean) As Boolean

            Dim Value As Boolean = False

            If ValidarVisita(ValidarVisitanteID, False) = False Then
                Return Value
            End If

            If Me._SolicitarAutoRegOrdinario = True And blnGrabarVisAdmin = False Then
                Value = True
            Else

                Me.ApellidoPaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.ApellidoPaterno)
                Me.ApellidoMaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.ApellidoMaterno)
                Me.Nombres = Legolas.Components.Cadena.LimpiarEspacios(Me.Nombres)

                Dim objEnt As New Entity.Visita.Visitante
                With objEnt
                    .Codigo = Me.IDVisitante
                    .ApellidoPaterno = Me.ApellidoPaterno
                    .ApellidoMaterno = Me.ApellidoMaterno
                    .Nombres = Me.Nombres
                    .SexoID = Me.SexoID
                    .TipoDocumentoID = Me.TipoDocumentoID
                    .NumeroDocumento = Me.NumeroDocumento
                    .FechaNacimiento = Me.FechaNacimiento
                    .NacionalidadID = Me.IDNacionalidad
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                End With

                objBssVis = New Bussines.Visita.Visitante
                Me.IDVisitante = objBssVis.Grabar(objEnt)

                'si el resultado es correcto
                If Me.IDVisitante > 0 Then
                    Value = True
                End If

            End If

            blnGrabarVisAdmin = False

            'verifivar si se realizo una valdiacion y extracion de datos en la visita 
            If Value = True And blnGrabarValServicioVisNuevo = True Then
                objBssVis = New Bussines.Visita.Visitante
                objBssVis.GrabarValidacionReniec(Me.IDVisitante, Legolas.Configuration.Usuario.Codigo, Me._FechaVisita, Me.VisitaValidadoServicio)
                blnGrabarValServicioVisNuevo = False
            End If

            If Me.IDVisitante > 0 And MensajeGrabar = True Then
                Me.VisitanteNuevo = True
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            End If

            Return Value

        End Function
        Private Function AGrabarVisitante() As Integer

            Dim value As Integer = -1

            Dim objEnt As New Entity.Visita.Visitante
            With objEnt
                .Codigo = Me.IDVisitante
                .TipoDocumentoID = Me.TipoDocumentoID
                .NumeroDocumento = Me.NumeroDocumento
                .ApellidoPaterno = Me.ApellidoPaterno
                .ApellidoMaterno = Me.ApellidoMaterno
                .Nombres = Me.Nombres
                .NacionalidadID = Me.IDNacionalidad
                .SexoID = Me.SexoID
                .FechaNacimiento = Me.FechaNacimiento
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            objBssVis = New Bussines.Visita.Visitante
            value = objBssVis.Grabar(objEnt)

            Return value
        End Function
        Private Function AGrabarVisitanteRnc() As Integer

            Dim value As Integer = -1

            Dim objEnt As New Entity.Visita.Visitante
            With objEnt
                .Codigo = Me.IDVisitante
                .TipoDocumentoID = Me.TipoDocumentoID
                .NumeroDocumento = Me.NumeroDocumento
                .ApellidoPaterno = Me.ApellidoPaterno
                .ApellidoMaterno = Me.ApellidoMaterno
                .Nombres = Me.Nombres
                .NacionalidadID = Me.IDNacionalidad
                .SexoID = Me.SexoID
                .FechaNacimiento = Me.FechaNacimiento
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            objBssVis = New Bussines.Visita.Visitante
            value = objBssVis.GrabarRnc(objEnt)

            Return value
        End Function
        Private Function AGrabarFoto() As Boolean

            Dim Value As Boolean = False

            If ValidarVisita(True, True) = False Then
                Return Value
            End If

            Dim objEnt As New Entity.Visita.Visitante
            With objEnt
                .Codigo = Me.IDVisitante
                .FotoID = Me.FotoID
                .FotoName = Me.FotoName
                .IDUsuarioCapturaFoto = Legolas.Configuration.Usuario.Codigo
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            Dim intIDVisitante As Integer = -1
            objBssVis = New Bussines.Visita.Visitante
            intIDVisitante = objBssVis.GrabarFoto(objEnt)

            'si el resultado es correcto
            If intIDVisitante > 0 Then
                Value = True
            End If

            Return Value

        End Function
        Public Function _GrabarVisitante() As Boolean

            Return AGrabarVisitante(True, False)
        End Function
        Private Function AGrabarFotoLocal(FotoNameExtension As String, PathFotoName As String) As Boolean

            Dim value As Boolean = False

            Dim objBssImag As New Bussines.Globall.ArchivoDigital

            Me.FotoID = objBssImag.GrabarImage(Me.FotoID, FotoNameExtension,
                                               PathFotoName, -1, Me._PenalID, Me._RegionID,
                                               Type.Enumeracion.ArchivoDigital.TipoImagen.Visitante)

            value = APPControls.Configuracion.WebService.SubirFoto(FotoNameExtension, PathFotoName, Configuracion.WebService.enmDirectotioTipo.Visitante)

            If value = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "La fotografia no fue grabada en el directorio, vuelva ha intentarlo")
            Else
                Legolas.Components.Archivo.FileDelete(PathFotoName)
            End If

            Return value

        End Function
#End Region
#Region "Form"
        Private Sub FRM_Foto()

            If Me.IDVisitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Antes de capturar la foto del visitante, grabe el registro")
                Me.txtNumDoc.Focus()
                Exit Sub
            End If

            Dim strCodigo As String = ""
            Dim strRegion As String = ""
            Dim strPenal As String = ""
            Dim strNumDoc As String = ""

            strRegion = Me._RegionID.ToString("00")
            strPenal = Me._PenalID.ToString("0000")
            strNumDoc = Legolas.Components.Cadena.Format(Me.NumeroDocumento, "000000000000")
            strCodigo = strRegion & strPenal & strNumDoc

            '/*capturar foto de la webcam, version02.1*/
            Me.FotoName = strCodigo & ".jpg"
            Dim strPathFoto As String = Legolas.Configuration.Path.FotoVisitante & Me.FotoName

            Dim blnCopio As Boolean = False
            Dim strRutaW As String = Legolas.Configuration.Path.Directorio & "windows81.ini".ToUpper.ToString

            '/*si el equipo dectecta el archivo windows8.1, sadlra la webcam para ese so*/
            If Legolas.Components.Archivo.FileExiste(strRutaW) = True Then

                Dim frm As New APPCamaraWeb.frmFotov3
                With frm
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        blnCopio = Legolas.Components.Archivo.FileCopy(._PathImagenTemporal, strPathFoto, True)
                        ._EliminarArchivo(._PathImagenTemporal)
                    End If
                End With
            Else

                Dim frm As New APPCamaraWeb.frmFoto
                With frm
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        blnCopio = Legolas.Components.Archivo.FileCopy(._PathImagenTemporal, strPathFoto, True)
                        ._EliminarArchivo(._PathImagenTemporal)
                    End If
                End With
            End If

            If blnCopio = True Then
                blnCopio = AGrabarFotoLocal(Me.FotoName, strPathFoto)
            Else
                Me.FotoName = ""
            End If

            'si la foto subio al web service
            If blnCopio = True Then
                ImagenFotoVisitante(Me.FotoName)

                'grabar la foto en la tabla
                AGrabarFoto()
            End If

        End Sub
        Private Function FRM_ValidarVisitaReniec(ByRef strMensaje As String, ByRef intMostrarTipoMensaje As Short) As Boolean

            Dim value As Boolean = False

            Dim intIDUsuario As Integer = Legolas.Configuration.Usuario.Codigo

            If Me._ValidarModuloVisConReniec = True Then

                'preguntamos el tipo de validacion del visitante

                Select Case Me._VisitanteValidadoReniec

                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado
                        'pasa directo
                        value = True

                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111
                        strMensaje = "El DNI solicitado se encuentra cancelado en el archivo magnético del RUIPN."
                        strMensaje = strMensaje & Chr(13) & Chr(13) & "Haga clic en el boton [Aceptar] para continuar el proceso de visitas o haga clic en el boton [Cancelar], para detener el proceso"

                        If MessageBox.Show(strMensaje, "Verificacion Reniec", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                            Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111
                            LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                            value = True
                        Else
                            intMostrarTipoMensaje = 0 'no muestra mensaje
                        End If

                    Case Else
                        'los que estan sin validar
                        'preguntar si es de tipo dni

                        If TipoDocumentoID = Type.Enumeracion.enmTipoDocumento.DNI Then

                            Dim objPersona As New APPWebService.ws_reniec_sede.NumeroDocumento
                            Dim intErrorReniec As Integer = -1
                            Dim strMensajeReniec As String = ""
                            Dim blnHayReniec As Boolean = True
                            Dim blnCancelarVerificacion As Boolean = False

                            objPersona = ConsultarReniec(Me.NumeroDocumento, blnHayReniec, blnCancelarVerificacion, intErrorReniec, strMensajeReniec)

                            If blnCancelarVerificacion = True Then
                                strMensaje = "Se canceló el proceso de verificacion con Reniec"
                            Else

                                If blnHayReniec = True Then

                                    If intErrorReniec <> 0 Then ' si presenta algun tipo de error en la reniec 

                                        strMensaje = "La verificacion con Reniec ha encontrado el siguiente problema;" & Chr(13) _
                                        & "Codigo Error: " & intErrorReniec & "-" & strMensajeReniec
                                        intMostrarTipoMensaje = -1

                                        'se verificas los distintos mensajes de errores que pueda traer la reniec
                                        Select Case intErrorReniec

                                            Case -1

                                                'esta opcion exceptua el pase de validacion de reniec, del evento que lo invoca.
                                                strMensaje = "En este momento no se encuentra disponible el Servicio de Reniec; " & strMensajeReniec
                                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                                                value = True

                                            Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111

                                                objBssVis = New Bussines.Visita.Visitante
                                                objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                            Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111)

                                                strMensaje = strMensaje & "." & Chr(13) & Chr(13) & "Haga clic en el boton [Aceptar] para continuar el proceso de visitas o haga clic en el boton [Cancelar], para detener el proceso"

                                                If MessageBox.Show(strMensaje, "Verificacion Reniec", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                                                    Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111
                                                    LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                    value = True
                                                Else
                                                    intMostrarTipoMensaje = 0 'no muestra emnsaje
                                                End If

                                        End Select

                                    Else

                                        If Not objPersona Is Nothing Then

                                            'preguntamos si el dni devulto x reniec es el mismo
                                            If objPersona.NumeroDNI = Me.NumeroDocumento Then

                                                If Me.IDVisitante < 1 Then 'cuando se extre los datos de un nuevo visitante
                                                    Dim lngFecNac As Long = 0
                                                    With objPersona
                                                        Me.ApellidoPaterno = .ApellidoPaterno
                                                        Me.ApellidoMaterno = .ApellidoMaterno
                                                        Me.Nombres = .Nombres
                                                        Me.IDNacionalidad = 141 'peru
                                                        Me.SexoID = .Sexo

                                                        If .FechaNacimiento.Length > 8 Then
                                                            lngFecNac = Legolas.Components.FechaHora.FechaLong(.FechaNacimiento)
                                                        End If

                                                        Me.FechaNacimiento = lngFecNac
                                                        Me.UscFotografia1._ShowFotoVisitante_Byte(.FotoByte)
                                                    End With
                                                End If

                                                Dim objBssVisReniec As New Bussines.Visita.VisitanteReniec
                                                Dim blnValidarVista As Boolean = False
                                                blnValidarVista = objBssVisReniec.ValidarVisitante(objPersona, Me.NumeroDocumento, Me.ApellidoPaterno, Me.ApellidoMaterno,
                                                                                                   Me.Nombres, Me.SexoID, Me.FechaNacimiento)

                                                If blnValidarVista = True Then

                                                    Dim intValue As Integer = -1

                                                    'si el id de la visita esta en la bd, entonces lo grabamos
                                                    If Me.IDVisitante > 0 Then
                                                        objBssVis = New Bussines.Visita.Visitante
                                                        intValue = objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                                    Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado)
                                                    End If

                                                    'marcarlo
                                                    Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado
                                                    HabilitarDatosVisitante(False)
                                                    LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                    value = True

                                                Else
                                                    Dim frm As New Visita.Visitante.frmReniecLinea
                                                    With frm
                                                        ._objPersona1 = objPersona
                                                        ._DatosOrigen(Me.NumeroDocumento, Me.ApellidoPaterno, Me.ApellidoMaterno,
                                                                                                   Me.Nombres, Me.SexoID, Me.FechaNacimiento)

                                                        If .ShowDialog = DialogResult.OK Then
                                                            value = True

                                                            Select Case ._TipoRespuesta
                                                                Case frmReniecLinea.enmTipoRespuesta.Omitir

                                                                    Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.Diferencias
                                                                    If ._HayRestriccion = True Then
                                                                        LeyendaValidacion_Servicio(-1)
                                                                    Else
                                                                        LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                                    End If

                                                                Case frmReniecLinea.enmTipoRespuesta.Reemplazar

                                                                    With objPersona
                                                                        Me.ApellidoPaterno = .ApellidoPaterno
                                                                        Me.ApellidoMaterno = .ApellidoMaterno
                                                                        Me.Nombres = .Nombres
                                                                        Me.IDNacionalidad = 141 'peru
                                                                        Me.SexoID = .Sexo
                                                                        If .FechaNacimiento.Length > 8 Then
                                                                            Me.FechaNacimiento = Legolas.Components.FechaHora.FechaLong(.FechaNacimiento)
                                                                        End If
                                                                    End With

                                                                    'si el id de la visita esta en la bd, entonces lo grabamos
                                                                    If Me.IDVisitante > 0 Then
                                                                        'grabamos los nuevos datos del visitante
                                                                        If AGrabarVisitanteRnc() > 0 Then
                                                                            'grabamos la validacion del servicio
                                                                            objBssVis = New Bussines.Visita.Visitante
                                                                            objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                                                    Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado)
                                                                        End If
                                                                    End If
                                                                    'marcarlo
                                                                    Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado
                                                                    HabilitarDatosVisitante(False)
                                                                    LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                            End Select

                                                        Else
                                                            strMensaje = "Se ha cancelado el proceso de Registro de Visita"
                                                        End If

                                                    End With
                                                End If

                                            End If

                                        End If

                                    End If

                                Else

                                    intMostrarTipoMensaje = -1
                                    value = True

                                End If

                            End If

                        Else
                            intMostrarTipoMensaje = -1
                            value = True
                        End If
                End Select

            Else
                value = True
            End If

            Return value

        End Function
        Private _strMensaje As String = ""
        Private _intMostrarTipoMensaje As Integer = -1
        Public Async Function FRM_ValidarVisitaReniecApi(strMensaje As String, intMostrarTipoMensaje As Integer) As Task(Of Boolean)

            Dim value As Boolean = False
            Dim intIDUsuario As Integer = Legolas.Configuration.Usuario.Codigo

            If Me._ValidarModuloVisConReniec = True Then
                'preguntamos el tipo de validacion del visitante
                Select Case Me._VisitanteValidadoReniec
                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado
                        'pasa directo
                        value = True
                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111
                        strMensaje = "El DNI solicitado se encuentra cancelado en el archivo magnético del RUIPN."
                        strMensaje = strMensaje & Chr(13) & Chr(13) & "Haga clic en el boton [Aceptar] para continuar el proceso de visitas o haga clic en el boton [Cancelar], para detener el proceso"

                        If MessageBox.Show(strMensaje, "Verificacion Reniec", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                            Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111
                            LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                            value = True
                        Else
                            intMostrarTipoMensaje = 0 'no muestra mensaje
                            _intMostrarTipoMensaje = 0
                        End If

                    Case Else
                        'los que estan sin validar
                        'preguntar si es de tipo dni
                        If TipoDocumentoID = Type.Enumeracion.enmTipoDocumento.DNI Then
                            'Dim objPersona As New APPWebService.ws_reniec_sede.NumeroDocumento
                            Dim intErrorReniec As Integer = -1
                            Dim strMensajeReniec As String = ""
                            Dim blnHayReniec As Boolean = True
                            Dim blnCancelarVerificacion As Boolean = False
                            Dim objPersona As New List(Of ResultReniec)
                            'objPersona = ConsultarReniec(Me.NumeroDocumento, blnHayReniec, blnCancelarVerificacion, intErrorReniec, strMensajeReniec)
                            objPersona = Await ConsultarReniecApiAsync(Me.NumeroDocumento, blnHayReniec, blnCancelarVerificacion, intErrorReniec, strMensajeReniec)

                            If blnCancelarVerificacion = True Then
                                strMensaje = "Se canceló el proceso de verificacion con Reniec"
                            Else
                                If objPersona.Item(0).codigoError = "" Then
                                    intErrorReniec = 0
                                Else
                                    intErrorReniec = objPersona.Item(0).codigoError
                                    strMensajeReniec = objPersona.Item(0).mensajeError
                                    strMensaje = objPersona.Item(0).mensajeError
                                    _strMensaje = objPersona.Item(0).mensajeError
                                End If
                                If blnHayReniec = True Then

                                    If intErrorReniec <> 0 Then ' si presenta algun tipo de error en la reniec 

                                        strMensaje = "La verificacion con Reniec ha encontrado el siguiente problema;" & Chr(13) _
                                        & "Codigo Error: " & intErrorReniec & "-" & strMensajeReniec
                                        intMostrarTipoMensaje = -1

                                        'se verificas los distintos mensajes de errores que pueda traer la reniec
                                        Select Case intErrorReniec

                                            Case -1

                                                'esta opcion exceptua el pase de validacion de reniec, del evento que lo invoca.
                                                strMensaje = "En este momento no se encuentra disponible el Servicio de Reniec; " & strMensajeReniec
                                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                                                value = True
                                            Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111

                                                objBssVis = New Bussines.Visita.Visitante
                                                objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                            Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111)

                                                strMensaje = strMensaje & "." & Chr(13) & Chr(13) & "Haga clic en el boton [Aceptar] para continuar el proceso de visitas o haga clic en el boton [Cancelar], para detener el proceso"

                                                If MessageBox.Show(strMensaje, "Verificacion Reniec", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                                                    Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111
                                                    LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                    value = True
                                                Else
                                                    intMostrarTipoMensaje = 0 'no muestra emnsaje
                                                End If
                                        End Select
                                    Else

                                        If Not objPersona Is Nothing Then
                                            'preguntamos si el dni devulto x reniec es el mismo
                                            For Each objReniec As ResultReniec In objPersona
                                                With objReniec
                                                    If .numeroDNI = Me.NumeroDocumento Then
                                                        If Me.IDVisitante < 1 Then 'cuando se extre los datos de un nuevo visitante
                                                            Dim lngFecNac As Long = 0
                                                            With objReniec
                                                                Me.ApellidoPaterno = .apellidoPaterno
                                                                Me.ApellidoMaterno = .apellidoMaterno
                                                                Me.Nombres = .nombres
                                                                Me.IDNacionalidad = 141 'peru
                                                                Me.SexoID = .sexo

                                                                If .fechaNacimiento.Length > 8 Then
                                                                    lngFecNac = Legolas.Components.FechaHora.FechaLong(.fechaNacimiento)
                                                                End If

                                                                Me.FechaNacimiento = lngFecNac
                                                                Dim imageBytes As Byte() = Convert.FromBase64String(.fotoByte)
                                                                Me.UscFotografia1._ShowFotoVisitante_Byte(imageBytes)
                                                            End With
                                                        End If

                                                        Dim objBssVisReniec As New Bussines.Visita.VisitanteReniec
                                                        Dim blnValidarVista As Boolean = False
                                                        blnValidarVista = objBssVisReniec.ValidarVisitanteApi(objPersona, Me.NumeroDocumento, Me.ApellidoPaterno, Me.ApellidoMaterno,
                                                                                                               Me.Nombres, Me.SexoID, Me.FechaNacimiento)

                                                        If blnValidarVista = True Then

                                                            Dim intValue As Integer = -1

                                                            'si el id de la visita esta en la bd, entonces lo grabamos
                                                            If Me.IDVisitante > 0 Then
                                                                objBssVis = New Bussines.Visita.Visitante
                                                                intValue = objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                                                Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado)
                                                            End If

                                                            'marcarlo
                                                            Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado
                                                            HabilitarDatosVisitante(False)
                                                            LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                            value = True

                                                        Else
                                                            Dim frm As New Visita.Visitante.frmReniecLinea
                                                            With frm
                                                                ' ._objPersona = objPersona
                                                                .objPersona = objPersona
                                                                ._DatosOrigen(Me.NumeroDocumento, Me.ApellidoPaterno, Me.ApellidoMaterno,
                                                                                                               Me.Nombres, Me.SexoID, Me.FechaNacimiento)

                                                                If .ShowDialog = DialogResult.OK Then
                                                                    value = True

                                                                    Select Case ._TipoRespuesta
                                                                        Case frmReniecLinea.enmTipoRespuesta.Omitir

                                                                            Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.Diferencias
                                                                            If ._HayRestriccion = True Then
                                                                                LeyendaValidacion_Servicio(-1)
                                                                            Else
                                                                                LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                                            End If

                                                                        Case frmReniecLinea.enmTipoRespuesta.Reemplazar

                                                                            With objReniec
                                                                                Me.ApellidoPaterno = .apellidoPaterno
                                                                                Me.ApellidoMaterno = .apellidoMaterno
                                                                                Me.Nombres = .nombres
                                                                                Me.IDNacionalidad = 141 'peru
                                                                                Me.SexoID = .sexo
                                                                                If .fechaNacimiento.Length > 8 Then
                                                                                    Me.FechaNacimiento = Legolas.Components.FechaHora.FechaLong(.fechaNacimiento)
                                                                                End If
                                                                            End With
                                                                            'si el id de la visita esta en la bd, entonces lo grabamos
                                                                            If Me.IDVisitante > 0 Then
                                                                                'grabamos los nuevos datos del visitante
                                                                                If AGrabarVisitanteRnc() > 0 Then
                                                                                    'grabamos la validacion del servicio
                                                                                    objBssVis = New Bussines.Visita.Visitante
                                                                                    objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                                                                Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado)
                                                                                End If
                                                                            End If
                                                                            'marcarlo
                                                                            Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado
                                                                            HabilitarDatosVisitante(False)
                                                                            LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                                    End Select

                                                                Else
                                                                    _strMensaje = "Se ha cancelado el proceso de Registro de Visita"
                                                                End If

                                                            End With
                                                        End If

                                                    End If

                                                End With
                                            Next

                                        End If

                                    End If

                                Else

                                    intMostrarTipoMensaje = -1
                                    value = True

                                End If

                            End If

                        Else
                            intMostrarTipoMensaje = -1
                            value = True
                        End If
                End Select

            Else
                value = True
            End If

            Return value

        End Function

        Private Function FRM_ValidarVisitaMigraciones(ByRef strMensaje As String, ByRef intMostrarTipoMensaje As Short) As Boolean

            Dim value As Boolean = False

            Dim intIDUsuario As Integer = Legolas.Configuration.Usuario.Codigo

            If Me._ValidarModuloVisConMigraciones = True Then

                'preguntamos el tipo de validacion del visitante

                Select Case Me.VisitaValidadoServicio

                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                        'pasa directo
                        value = True

                    Case Else
                        'los que estan sin validar
                        'preguntar si es de tipo dni

                        If TipoDocumentoID = Type.Enumeracion.enmTipoDocumento.CE Or TipoDocumentoID = Type.Enumeracion.enmTipoDocumento.PTP Or TipoDocumentoID = Type.Enumeracion.enmTipoDocumento.CPP Then

                            Dim objVisitanteServicio As New APPWebService.Result.ConsultarExtranjero
                            Dim intErrorServicio As Integer = -1
                            Dim strMensajeServicio As String = ""
                            Dim blnHayServicio As Boolean = True
                            Dim blnCancelarVerificacion As Boolean = False

                            objVisitanteServicio = ConsultarMigraciones(Me.TipoDocumentoID, Me.NumeroDocumento, blnHayServicio, blnCancelarVerificacion)

                            If blnCancelarVerificacion = True Then
                                strMensaje = "Se canceló el proceso de verificacion con Migraciones"
                            Else

                                If blnHayServicio = True Then

                                    intErrorServicio = objVisitanteServicio.ErrorCodigo
                                    strMensajeServicio = objVisitanteServicio.ErrorMensaje

                                    If intErrorServicio <> 0 Then ' si presenta algun tipo de error en el servicio de la ws 

                                        strMensaje = "La verificacion con el Servicio de Migraciones, ha encontrado el siguiente problema;" & Chr(13) _
                                        & "Codigo Error: " & intErrorServicio & "-" & strMensajeServicio
                                        intMostrarTipoMensaje = -1

                                    Else

                                        If Not objVisitanteServicio Is Nothing Then

                                            'preguntamos si el dni devolvio x el servicio web, es el mismo
                                            'If objVisitanteServicio.NumeroDocumento = Me.NumeroDocumento Then

                                            If Me.IDVisitante < 1 Then 'cuando se extre los datos de un nuevo visitante
                                                Dim lngFecNac As Long = 0
                                                With objVisitanteServicio
                                                    Me.ApellidoPaterno = .PrimerApellido
                                                    Me.ApellidoMaterno = .SegundoApellido
                                                    Me.Nombres = .Nombres
                                                    Me.IDNacionalidad = .IDNacionalidad
                                                    Me.SexoID = .IDSexo
                                                    Me.FechaNacimiento = .FechaNacimiento
                                                    Me.UscFotografia1._ShowFotoVisitante_Byte(.FotoByte)
                                                End With
                                            End If

                                            Dim objBssVisReniec As New Bussines.Visita.VisitanteReniec
                                            Dim blnValidarVista As Boolean = False

                                            blnValidarVista = objBssVisReniec.ValidarDatosMigraciones(objVisitanteServicio, Me.NumeroDocumento, Me.ApellidoPaterno,
                                                                                                              Me.ApellidoMaterno, Me.Nombres, Me.SexoID, Me.FechaNacimiento,
                                                                                                               Me.IDNacionalidad)

                                            If blnValidarVista = True Then

                                                Dim intValue As Integer = -1
                                                'si el id de la visita esta en la bd, entonces lo grabamos
                                                If Me.IDVisitante > 0 Then
                                                    objBssVis = New Bussines.Visita.Visitante
                                                    intValue = objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                                        Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado)
                                                End If

                                                'marcarlo
                                                Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                                                HabilitarDatosVisitante(False)
                                                LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                value = True

                                            Else
                                                Dim frm As New Visita.Visitante.frmMigracionesPopup
                                                With frm
                                                    ._objVisitanteServicio = objVisitanteServicio
                                                    ._DatosOrigen(Me.TipoDocumentoID, Me.NumeroDocumento, Me.ApellidoPaterno, Me.ApellidoMaterno,
                                                                                                       Me.Nombres, Me.SexoID, Me.FechaNacimiento, Me.IDNacionalidad)

                                                    If .ShowDialog = DialogResult.OK Then

                                                        value = True
                                                        Select Case ._TipoRespuesta
                                                            Case frmMigracionesPopup.enmTipoRespuesta.Omitir

                                                                Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.Diferencias
                                                                If ._HayRestriccion = True Then
                                                                    LeyendaValidacion_Servicio(-1)
                                                                Else
                                                                    LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                                End If

                                                            Case frmMigracionesPopup.enmTipoRespuesta.Reemplazar

                                                                With objVisitanteServicio
                                                                    Me.ApellidoPaterno = .PrimerApellido
                                                                    Me.ApellidoMaterno = .SegundoApellido
                                                                    Me.Nombres = .Nombres
                                                                    Me.IDNacionalidad = .IDNacionalidad
                                                                    Me.SexoID = .IDSexo
                                                                    Me.FechaNacimiento = .FechaNacimiento
                                                                End With

                                                                'si el id de la visita esta en la bd, entonces lo grabamos
                                                                If Me.IDVisitante > 0 Then
                                                                    'grabamos los nuevos datos del visitante
                                                                    AGrabarVisitante()
                                                                    'grabamos la validacion del servicio
                                                                    objBssVis = New Bussines.Visita.Visitante
                                                                    objBssVis.GrabarValidacionReniec(Me.IDVisitante, intIDUsuario, Me._FechaVisita,
                                                                                                                        Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado)
                                                                End If

                                                                'marcarlo
                                                                Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                                                                HabilitarDatosVisitante(False)
                                                                LeyendaValidacion_Servicio(Me.VisitaValidadoServicio)
                                                        End Select

                                                    Else
                                                        strMensaje = "Se ha cancelado el proceso de Registro de Visita"
                                                    End If

                                                End With
                                            End If

                                            'End If

                                        End If

                                    End If

                                Else

                                    intMostrarTipoMensaje = -1
                                    value = True

                                End If

                            End If

                        Else
                            intMostrarTipoMensaje = -1
                            value = True
                        End If
                End Select

            Else
                value = True
            End If

            Return value

        End Function
        Private Function FRM_CapturarVerificarHuella(ByRef strMensaje As String) As Boolean

            Dim blnSigueProceso As Boolean = False
            'Dim blnServicioHuella As Boolean = True
            Dim blnUsarHuella As Boolean = False
            Dim blnVisValReniec As Boolean = False

            Dim lngFecha As Long = Me._FechaVisita

            'Dim objBss As New Bussines.Visita.ConfigHuella
            'blnServicioHuella = Not objBss.ValidarServicioBaja(lngFecha, Me._RegionID, Me._PenalID)

            If Me._HabilitarHuellaDigital = True Then
                'If blnServicioHuella = True Then

                If Me._HabilitarCapHuellaValReniec = True Then

                    If TipoDocumentoID = Type.Enumeracion.enmTipoDocumento.DNI Then

                        If Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado Then
                            blnUsarHuella = True
                        End If

                    Else
                        blnUsarHuella = True
                    End If

                Else
                    blnUsarHuella = True
                End If

                'End If
            End If

            'validar que solo en el penal configurado, muestre el form de captura de huella
            If blnUsarHuella = True Then

                Me._VisitanteNumeroRecaptura = 0
                Dim objBssVisHue As New Bussines.Biometria.VisitanteHuella

                Select Case Me.VisitaTieneHuella
                    Case Type.Enumeracion.Visita.Visitante.TieneHuella.SI

                        Dim intIDVisitante As Integer = -1
                        Dim blnRecapturar As Boolean = False
                        Dim blnTieneMinimoUnaHuella As Boolean = False

                        blnTieneMinimoUnaHuella = objBssVisHue.TieneMinimoUnaHuella(Me._IDVisitante, Me._RegionID, Me._PenalID)

                        If blnTieneMinimoUnaHuella = True Then

                            intIDVisitante = FRM_VerificarHuella(blnRecapturar)

                        Else
                            'si no tiene huella se inicia el proceso de recaptura
                            blnRecapturar = True
                        End If

                        '/*iniciar el proceso de recapturar*/
                        If blnRecapturar = True Then

                            Dim frmRecap As New Visita.Huella.frmCapturapopup
                            With frmRecap
                                ._IDRegion = Me._RegionID
                                ._IDPenal = Me._PenalID
                                ._IDTipoDocumento = Me._IDTipoDocumento
                                ._NumeroDocumento = Me._NumeroDocumento
                                ._IDVisitante = Me._IDVisitante
                                ._MostrarHuellas = True

                                If .ShowDialog() = DialogResult.OK Then

                                    Me.VisitaTieneHuella = ._VisitanteTieneHuella  'tiene huella
                                    intIDVisitante = Me._IDVisitante
                                    Me._VisitanteNumeroRecaptura = objBssVisHue.NumeroRecaptura(Me._IDVisitante, Me._RegionID, Me._PenalID)

                                    Select Case Me.VisitaTieneHuella
                                        Case Type.Enumeracion.Visita.Visitante.TieneHuella.SI
                                            Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.Recaptura

                                        Case Type.Enumeracion.Visita.Visitante.TieneHuella.Obs
                                            Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.HuellaObsRecaptura

                                    End Select

                                    MostrarHuellaObs()

                                Else
                                    strMensaje = "No se ha detectado la Captura Biometrica (Huella Digital), no se puede continuar con el proceso. Vuelva ha intentar"
                                    blnSigueProceso = False
                                End If

                            End With

                        End If
                        '/**********************/

                        'consultar si el id de la huellacapturada, es igual al id de la huella almacenada del visitante
                        If Me.IDVisitante = intIDVisitante Then
                            blnSigueProceso = True
                        Else
                            strMensaje = "No se ha detectado la Verificacion Biometrica (Huella Digital), no se puede continuar con el proceso. Vuelva ha intentar"
                            blnSigueProceso = False
                        End If

                    Case Type.Enumeracion.Visita.Visitante.TieneHuella.Obs

                        Me._VisitanteNumeroRecaptura = objBssVisHue.NumeroRecaptura(Me._IDVisitante, Me._RegionID, Me._PenalID)

                        If Me._VisitanteNumeroRecaptura = 0 Then
                            Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.HuellaObs
                        Else
                            Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.HuellaObsRecaptura
                        End If

                        blnSigueProceso = True

                    Case Else

                        Dim frm As New Visita.Huella.frmCapturapopup
                        With frm
                            ._IDRegion = Me._RegionID
                            ._IDPenal = Me._PenalID
                            ._IDVisitante = Me.IDVisitante
                            ._IDTipoDocumento = Me.TipoDocumentoID
                            ._NumeroDocumento = Me.NumeroDocumento

                            If .ShowDialog() = DialogResult.OK Then

                                Me.VisitaTieneHuella = ._VisitanteTieneHuella  'tiene huella
                                blnSigueProceso = True

                                Select Case Me.VisitaTieneHuella
                                    Case Type.Enumeracion.Visita.Visitante.TieneHuella.SI
                                        Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.CapturaHuella

                                    Case Type.Enumeracion.Visita.Visitante.TieneHuella.Obs
                                        Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.HuellaObs

                                End Select

                                MostrarHuellaObs()
                            Else
                                strMensaje = "No se ha detectado la Captura Biometrica (Huella Digital), no se puede continuar con el proceso. Vuelva ha intentar"
                            End If

                        End With

                End Select

            Else
                blnSigueProceso = True
            End If

            Return blnSigueProceso

        End Function

        Private Function FRM_VerificarHuella(ByRef blnRecapturar As Boolean) As Integer

            Dim value As Integer = -1

            Dim objAfis As New APPControlHuellaVisita.IdentificarDispositivo
            Dim objBssVisHue As New Bussines.Biometria.VisitanteHuella

            'pregunta x el tipo de dispostivo biometrico conectado
            Select Case objAfis.IdentificarDispositivo

                Case APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.RealScanG1

                    Dim frm As New APPControls.Visita.Huella.frmIdentificarPopup
                    With frm
                        ._TipoBusqueda = Huella.frmIdentificarPopup.enmTipoBusqueda.Verificacion
                        ._IDRegion = Me._RegionID
                        ._IDPenal = Me._PenalID
                        ._IDTipoDocumento = Me.TipoDocumentoID
                        ._NumeroDocumento = Me.NumeroDocumento
                        ._IDVisitante = Me.IDVisitante

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                            value = ._IDVisitanteReturn
                            blnRecapturar = ._RecapturarReturn

                            Me._VisitanteNumeroRecaptura = objBssVisHue.NumeroRecaptura(Me._IDVisitante, Me._RegionID, Me._PenalID)

                            If blnRecapturar = False Then

                                If Me._VisitanteNumeroRecaptura = 0 Then
                                    Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.VerificacionHuella
                                Else
                                    Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.VerificacionHuellaRecaptura
                                End If

                            End If

                        End If
                    End With

                Case APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS10, APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS88H

                    Dim objEntVisHue As New Entity.Biometria.VisitanteHuella
                    objBssVisHue = New Bussines.Biometria.VisitanteHuella

                    objEntVisHue = objBssVisHue.ListarHuellaxIDVisitante(Me._IDVisitante, Me._RegionID, Me._PenalID, "")

                    Dim intIDVisitaCol As New List(Of Integer)
                    Dim intIDVisita As Integer = -1

                    Dim frm As New APPControlHuellaVisita.Huellero.FS10.frmIdentificarPopup
                    With frm
                        ._CNBDHuella = APPControls.Configuracion.ConexionBD.CN_BD_HuellaVisita
                        ._TipoBusqueda = APPControlHuellaVisita.Huellero.FS10.frmIdentificarPopup.enmTipoBusqueda.Verificacion
                        ._IDTipoDocumento = Me.TipoDocumentoID
                        ._NumeroDocumento = Me.NumeroDocumento

                        ._DatosHuellaVerificacion(objEntVisHue.TipoCapturaIzquierdo, objEntVisHue.IDIndiceIzquierdo, objEntVisHue.IDPulgarIzquierdo,
                                                    objEntVisHue.CalidadIndiceIzquierdo, objEntVisHue.CalidadPulgarIzquierdo, objEntVisHue.TipoCapturaDerecho,
                                                    objEntVisHue.IDIndiceDerecho, objEntVisHue.IDPulgarDerecho, objEntVisHue.CalidadIndiceDerecho,
                                                    objEntVisHue.CalidadPulgarDerecho)

                        If .ShowDialog = Windows.Forms.DialogResult.OK Then

                            blnRecapturar = ._RecapturarReturn

                            If blnRecapturar = False Then

                                'buscar la huella del visitante
                                objBssVis = New Bussines.Visita.Visitante
                                For Each j As Integer In ._ReturnIDTemplateColRpta
                                    intIDVisitaCol.Add(objBssVis.BuscarHuella(j, Me._RegionID, Me._PenalID))
                                Next

                                For Each j As Integer In intIDVisitaCol
                                    intIDVisita = j
                                Next

                                If intIDVisita > 0 Then

                                    value = intIDVisita

                                    Me._VisitanteNumeroRecaptura = objBssVisHue.NumeroRecaptura(Me._IDVisitante, Me._RegionID, Me._PenalID)

                                    If blnRecapturar = False Then

                                        If Me._VisitanteNumeroRecaptura = 0 Then
                                            Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.VerificacionHuella
                                        Else
                                            Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.VerificacionHuellaRecaptura
                                        End If

                                    End If

                                Else

                                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                                        "La Huella capturada del dedo seleccionado, no coincide con los datos del visitante. Vuelva ha intentarlo", "Verificacion")
                                End If

                            End If

                        End If

                    End With
            End Select

            Return value

        End Function
        Private Sub Form_DetalleSancion(ByVal Tipo As Integer)

            Dim frm As New Visita.frmSancionDetallePopup
            With frm
                ._Codigo = Me.IDVisitante
                ._TipoVista = frmSancionDetallePopup.enmTipo.Visitante
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Reniec"
        Private Async Function ConsultarReniecApiAsync(strNumeroDNI As String, blnHayReniec As Boolean, blnCancelarVerificacion As Boolean, intCodigoErrorReniec As Integer, strMensajeReniec As String) As Task(Of List(Of ResultReniec))
            Dim blnValor As Boolean = False
            Dim bss As New Bussines.ReniecConsulta
            Dim ListaRENIEC As New List(Of ResultReniec)()

            ListaRENIEC = Await bss.ConsultarReniec(1, strNumeroDNI, "", "", "", Me.Name)

            strMensajeReniec = ListaRENIEC.Item(0).mensajeError
            Dim abc As String = ListaRENIEC.Item(0).codigoError
            Dim ab1 As String = ListaRENIEC.Item(0).restriccion
            Dim ab2 As String = ListaRENIEC.Item(0).numeroTotalCoincidencias
            'If ListaRENIEC.Item(0).codigoError = "" Then intCodigoErrorReniec = 0
            Return ListaRENIEC
        End Function

        Private Function ConsultarReniec(strNumeroDNI As String, ByRef blnHayReniec As Boolean,
                                         ByRef blnCancelarVerificacion As Boolean, ByRef intCodigoErrorReniec As Integer, ByRef strMensajeReniec As String) As APPWebService.ws_reniec_sede.NumeroDocumento

            Dim value As New APPWebService.ws_reniec_sede.NumeroDocumento
            Me.SuspendLayout()

            If Me.BackgroundWorker1.IsBusy = True Then
                Return value
            End If

            Me.BackgroundWorker1.RunWorkerAsync(strNumeroDNI)

            blnCancelarVerificacion = False

            frmLoad = New Load.frmLoad02
            frmLoad._TipoImagen = APPControls.Load.frmLoad02.enmTipoImagen.Reniec

            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker1.CancelAsync()
                'Me.BackgroundWorker1.Dispose()
                blnCancelarVerificacion = True
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            If blnCancelarVerificacion = False Then
                value = objVisitanteReniec.objPersona
                blnHayReniec = objVisitanteReniec.HayServicioReniec
                intCodigoErrorReniec = objVisitanteReniec.ErrorCodigo
                strMensajeReniec = objVisitanteReniec.ErrorMensaje
            End If

            Return value

        End Function

        Private Function ConsultarMigraciones(intTipoDocumento As Short, strNumeroDoc As String, ByRef blnHayServicio As Boolean,
                                              ByRef blnCancelarVerificacion As Boolean) As APPWebService.Result.ConsultarExtranjero

            Dim value As New APPWebService.Result.ConsultarExtranjero
            Me.SuspendLayout()

            If Me.BackgroundWorker2.IsBusy = True Then
                Return value
            End If

            Dim objArray As New ArrayList
            objArray.Add(intTipoDocumento)
            objArray.Add(strNumeroDoc)

            Me.BackgroundWorker2.RunWorkerAsync(objArray)

            blnCancelarVerificacion = False

            frmLoad = New Load.frmLoad02
            frmLoad._TipoImagen = APPControls.Load.frmLoad02.enmTipoImagen.Migraciones

            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker2.CancelAsync()
                blnCancelarVerificacion = True
            End If

            Me.ResumeLayout(True)
            frmLoad.Refresh()

            If blnCancelarVerificacion = False Then
                value = objVisitanteMigraciones
                blnHayServicio = objVisitanteMigraciones.HayServicio
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

        Private Function ConsultarMigracionesHilo(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As APPWebService.Result.ConsultarExtranjero

            Dim value As New APPWebService.Result.ConsultarExtranjero

            If worker.CancellationPending = True Then
                e.Cancel = True
            Else

                Dim objBssMigraciones As New APPWebService.MigracionesConsulta

                Try
                    value = objBssMigraciones.WS_ConsultarExtranjero(Legolas.Configuration.Data.ConexionIni, e.Argument(0), e.Argument(1))

                    Select Case value.ErrorCodigo
                        Case 0 'ok
                            value.HayServicio = True
                        Case -20 'el numero no existe
                            value.HayServicio = True
                        Case Else
                            value.HayServicio = False
                    End Select

                Catch ex As Exception
                    value.HayServicio = False
                    value.ErrorCodigo = -1
                    value.ErrorMensaje = ex.Message
                End Try

            End If

            Return value

        End Function

        Private Sub LeyendaValidacion_Servicio(objEnumVisitanteVal As Type.Enumeracion.Visita.Visitante.ValidadoServicio)

            'Reniec y Migraciones
            Dim objColor As Color
            Select Case objEnumVisitanteVal
                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar
                    objColor = Color.White

                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado, Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                    objColor = Color.LightGreen

                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.Diferencias

                    objColor = Color.Gold

                Case Else
                    objColor = Color.IndianRed
            End Select

            Me.pnlFotografia.BackColor = objColor

        End Sub

#End Region
#Region "Otros"
        Private blnValoresxDefault As Boolean = False

        Public Sub _HabilitarDatosVisitante(vf As Boolean)

            Me.HabilitarDatosVisitante(vf)

        End Sub
        Private Sub HabilitarTipoyNumeroDocumento(vf As Boolean)

            Me.cbbTipoDoc.Enabled = vf
            Me.txtNumDoc.Enabled = vf
            Me.btnBuscar.Enabled = vf

        End Sub
        Private Function ConcatenarPropiedadesVisitante() As String


            Dim value As String = ""
            Dim strFecha As String = ""

            strFecha = Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)

            value = Me.NumeroDocumento.Trim & Me.ApellidoPaterno.Trim & Me.ApellidoMaterno.Trim &
            Me.Nombres.Trim & Me.IDNacionalidad & Me.SexoID & strFecha.Trim

            Return value

        End Function
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            With Me.UscFotografia1
                '._TipoImagen = Foto.uscFotografia.DirectotioTipo.Visitante
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub
        Private Function ValidarPropiedadesParametricas() As Boolean

            Dim value As Boolean = False

            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_RegionID], no esta inicializado")
                Return value
            End If

            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_PenalID], no esta inicializado")
                Return value
            End If

            If Me._FechaVisita < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_FechaVisita], no esta inicializado")
                Return value
            End If

            value = True

            Return value

        End Function
        Private Sub ValoresxDefault()

            blnValoresxDefault = False

            ComboDocumentoTipo(_mostrarTipoDocumentosValidos)

            ComboOtros()
            Me._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong

            Me.TipoDocumentoID = 10 'dni     
            RaiseEvent _SelectedIndexChanged_TipoDocumento(Me.TipoDocumentoID)

            Me.IDNacionalidad = 141 'peru
            '/*otros*/
            Me.btnMenores.Visible = False
            Me.btnLimpiar.Visible = False

            Select Case Me._TipoVisita
                Case Type.Enumeracion.Visita.EnumTipo.Penal
                    Me.btnMenores.Visible = True
                Case Else
                    Me.btnLimpiar.Visible = True
            End Select

            blnValoresxDefault = True

        End Sub
        Private Sub HabilitarMensaje(ByVal Tipo As Type.Enumeracion.Visita.Visitante.Focus)

            Select Case Tipo
                Case Type.Enumeracion.Visita.Visitante.Focus.NumeroDocumento
                    Me.lblMensaje.Text = "Seleccione el tipo de documento e ingrese el numero de documento, luego presione la tecla [Enter]."
                Case Type.Enumeracion.Visita.Visitante.Focus.FechaNacimiento
                    Me.lblMensaje.Text = "Ingrese la fecha de nacimiento completa, solo numeros dia, mes y año. Ejemplo; 12/12/1985."
                Case Else
                    Me.lblMensaje.Text = ""
            End Select
        End Sub
        Private Sub ALimpiarVisitante(Optional ByVal NumeroDocumento As Boolean = False)

            Me.IDVisitante = -1
            Me.VisitanteNuevo = False

            HabilitarTipoyNumeroDocumento(True)

            If NumeroDocumento = True Then
                Me.PaseNumero = ""
                Me.NumeroDocumento = ""
                Me.TipoDocumentoID = 10 'dni
            End If

            Me.ApellidoPaterno = ""
            Me.ApellidoMaterno = ""
            Me.Nombres = ""
            Me.IDNacionalidad = 141 'peruana
            Me.SexoID = -1
            Me.FechaNacimiento = 0

            Me.FotoID = -1
            Me.FotoName = ""

            Me.VisitaValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar
            Me.VisitaTieneHuella = Type.Enumeracion.Visita.Visitante.TieneHuella.Ninguno
            Me._VisitanteIngresaPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.Ninguno

            Me.blnGrabarValServicioVisNuevo = False
            Me.blnGrabarVisAdmin = False

            Me.pnlFotografia.BackColor = Color.White
            Me.UscFotografia1._Limpiar()
            Me.pnlDatosVisitante.Enabled = False
            Me.btnGrabarVisitante.Enabled = False
            Me.pbHuellaObs.Visible = False

        End Sub
        Public Sub _ALimpiarVisitante(Optional ByVal NumeroDocumento As Boolean = False)
            ALimpiarVisitante(NumeroDocumento)
        End Sub
        Private Sub ValidarNumeroDocumento()

            'cantidad de caracteres
            Select Case Me.TipoDocumentoID
                Case Type.Enumeracion.enmTipoDocumento.LE, Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtNumDoc.MaxLength = 8

                Case Type.Enumeracion.enmTipoDocumento.CE, Type.Enumeracion.enmTipoDocumento.PTP, Type.Enumeracion.enmTipoDocumento.CPP
                    Me.txtNumDoc.MaxLength = 9

                Case Else
                    Me.txtNumDoc.MaxLength = 20
            End Select

            Select Case Me.TipoDocumentoID
                Case Type.Enumeracion.enmTipoDocumento.DNI

                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros

                Case Else
                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico

            End Select

            Me.txtNumDoc.Text = ""
            Me.txtNumDoc.Focus()

        End Sub
        Public Sub _LoadUsc()

            If ValidarPropiedadesParametricas() = False Then
                Exit Sub
            End If

            ValoresxDefault()
            LoadToolTipText()

        End Sub
        Public Sub _Focus()

            If Me.txtPaseNumero.Visible = True Then
                Me.txtPaseNumero.Focus()
            Else
                Me.txtNumDoc.Focus()
            End If

        End Sub
        Private Sub LoadToolTipText()

            With Me.ToolTip1
                .SetToolTip(Me.btnMenores, "Registrar datos de menores de edad")
                .SetToolTip(Me.btnCapurar, "Capturar fotografia por webcam")
                .SetToolTip(Me.btnGrabarVisitante, "Grabar datos del visitante")
                .SetToolTip(Me.txtNumDoc, "Presione la tecla [Enter]")
                .SetToolTip(Me.btnLimpiar, "Limpiar datos del visitante")
            End With

        End Sub
        Private Sub HabilitarDatosVisitante(vf As Boolean)

            Select Case Me.VisitaValidadoServicio
                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado, Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                    vf = False
                Case Else
                    Me.pnlDatosVisitante.Enabled = vf
            End Select

            Me.pnlDatosVisitante.Enabled = vf

        End Sub

        Private Sub MostrarHuellaObs()

            Me.pbHuellaObs.Visible = False

            Select Case Me.VisitaTieneHuella
                Case Type.Enumeracion.Visita.Visitante.TieneHuella.Obs
                    Me.pbHuellaObs.Visible = True
            End Select

        End Sub

        Public Sub _HabilitarBotonGrabar(blnVF As Boolean)

            Me.btnGrabarVisitante.Enabled = blnVF

        End Sub
#End Region
        Private Sub btnGrabarVisitante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarVisitante.Click

            Dim blnResultado As Boolean = False

            blnResultado = AGrabarVisitante(False, True)

            If Me.IDVisitante > 0 And blnResultado = True Then
                ListarSancionVisitante(Me.IDVisitante, Me._FechaVisita)
                BuscarProceso()
            End If

        End Sub

        Private Sub btnCapurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapurar.Click

            FRM_Foto()

        End Sub

        Private Sub btnMenores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenores.Click

            RaiseEvent _Click_BuscarMenores()

        End Sub

        Private Sub txtNumDoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumDoc.GotFocus

            HabilitarMensaje(Type.Enumeracion.Visita.Visitante.Focus.NumeroDocumento)
            Me.lblMensaje.Visible = True

        End Sub

        Private Sub txtNumDoc_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumDoc.KeyDown

            Select Case e.KeyCode
                Case Keys.Up
                    Me.txtPaseNumero.Focus()
                Case Keys.Down
                    Me.txtApePat.Focus()
            End Select

        End Sub

        Private Sub txtNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                RaiseEvent _Click_BuscarVisita()
                Buscar()
            End If

        End Sub

        Private Sub UscFotografia1__NoAutorizado_DoubleClick() Handles UscFotografia1._NoAutorizado_DoubleClick

            Form_DetalleSancion(1)

        End Sub

        Private Sub dtpFechaNac__GotFocus() Handles dtpFechaNac._GotFocus

            HabilitarMensaje(Type.Enumeracion.Visita.Visitante.Focus.FechaNacimiento)
            Me.lblMensaje.Visible = True

        End Sub

        Private Sub dtpFechaNac__KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaNac._KeyDown

            Select Case e.KeyCode
                Case Keys.Escape
                    Me.txtNom.Focus()
            End Select

        End Sub

        Private Sub dtpFechaNac__LostFocus() Handles dtpFechaNac._LostFocus

            Me.lblMensaje.Visible = False

        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

            ALimpiarVisitante(True)
            Me.txtPaseNumero.Focus()

        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

            RaiseEvent _Click_BuscarVisita()
            Buscar()

        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged1() Handles cbbTipoDoc._SelectedIndexChanged

            If Me.TipoDocumentoID > 0 And blnValoresxDefault = True Then
                Select Case Me.TipoDocumentoID
                    Case 3, 4, 10, 16, 17  '' Pasaporte, CE, DNI, PTP, CPP
                        ValidarNumeroDocumento()
                        RaiseEvent _SelectedIndexChanged_TipoDocumento(Me.TipoDocumentoID)
                    Case Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo de documento seleccionado no esta permitido para" + Chr(13) +
                                                                                 "realizar el Registro de Visitas.")
                        Exit Sub
                End Select
                'If Me.TipoDocumentoID = 3 Or Me.TipoDocumentoID = 4 Or Me.TipoDocumentoID = 10 Then
                '    ValidarNumeroDocumento()
                '    RaiseEvent _SelectedIndexChanged_TipoDocumento(Me.TipoDocumentoID)
                'Else
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo de documento seleccionado no esta permitido para" + Chr(13) +
                '                                                                 "realizar el Registro de Visitas.")
                '    Exit Sub
                'End If
            End If

        End Sub

        Private Sub txtApePat_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApePat.KeyDown

            Select Case e.KeyCode
                Case Keys.Up

                    If Me.txtNumDoc.Enabled = True Then
                        Me.txtNumDoc.Focus()
                    Else
                        Me.txtPaseNumero.Focus()
                    End If

                Case Keys.Down
                    Me.txtApeMat.Focus()
            End Select

        End Sub

        Private Sub txtApeMat_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApeMat.KeyDown

            Select Case e.KeyCode
                Case Keys.Up
                    Me.txtApePat.Focus()
                Case Keys.Down
                    Me.txtNom.Focus()
            End Select

        End Sub

        Private Sub txtNom_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNom.KeyDown

            Select Case e.KeyCode
                Case Keys.Up
                    Me.txtApeMat.Focus()
                Case Keys.Down
                    Me.cbbNacionalidad.Focus()
            End Select

        End Sub

        Private Sub txtPaseNumero_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPaseNumero.KeyDown

            Select Case e.KeyCode
                Case Keys.Down

                    If Me.txtNumDoc.Enabled = True Then
                        Me.txtNumDoc.Focus()
                    Else
                        Me.txtApePat.Focus()
                    End If
            End Select

        End Sub

        Private Sub cbbNacionalidad__KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) _
            Handles cbbNacionalidad._KeyDown,
            CbbSexo._KeyDown

            Select Case e.KeyCode
                Case Keys.Escape
                    Me.txtNom.Focus()
            End Select

        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker1 = Nothing
            End If

        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else
                e.Result = ConsultarReniecHilo(worker, e)
            End If

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            'frmLoad.Dispose()            
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()

                objVisitanteReniec = New Bussines.Visita.VisitanteReniec.objDTOPersona
                objVisitanteReniec = e.Result

            End If

        End Sub

        Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker2.CancellationPending = True Then
                e.Cancel = True
            Else
                e.Result = ConsultarMigracionesHilo(worker, e)
            End If

        End Sub

        Private Sub BackgroundWorker2_Disposed(sender As Object, e As EventArgs) Handles BackgroundWorker2.Disposed

            If Me.BackgroundWorker2.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker2 = Nothing
            End If

        End Sub

        Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted

            'frmLoad.Dispose()            
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()

                objVisitanteMigraciones = New APPWebService.Result.ConsultarExtranjero
                objVisitanteMigraciones = e.Result
            End If

        End Sub

        Private Sub cbbTipoDoc_Load(sender As Object, e As EventArgs) Handles cbbTipoDoc.Load

        End Sub
    End Class

End Namespace
