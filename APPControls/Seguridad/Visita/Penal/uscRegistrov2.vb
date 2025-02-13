Imports System.IO
Imports System.Net.Mail
Imports System.Net.Mime

Namespace Visita.Penal
    Public Class uscRegistrov2
        Private objBssMovimiento As Bussines.Visita.Movimiento = Nothing
        Private objBssVisitante As Bussines.Visita.Visitante = Nothing
        Private objBssInterno As Bussines.Visita.Interno = Nothing
        Private objBssCalendarioDetalle As Bussines.Visita.Programacion.CalendarioDetalle = Nothing
        'entitys
        Private objEntMov As Entity.Visita.Movimiento = Nothing
        Private objEntCalendarioDetalle As Entity.Visita.Programacion.Calendario = Nothing
        Private objEntTempMov As Entity.Visita.MovimientoCol = Nothing
        Private objEntTempMovMenor As Entity.Visita.MovimientoCol = Nothing
        Private ParentescoIDArray As List(Of Integer) = Nothing
        Private ParentescoNombreArray As List(Of String) = Nothing
#Region "Eventos"
        Public Event _Click_Form_Menores(InternoEtapaID As Short, VisitanteID As Integer, IDCalendarioDetalle As Integer, IDCalendatrioDetalleExtraordinario As Integer)
        Public Event _Click_Form_Internos(VisitanteID As Integer)
        Public Event _Click_Form_InternosPJ(intIDVisitante As Integer)
        Public Event _Click_Form_InternosHistoricos(VisitanteID As Integer)
        Public Event _Click_BuscarVisitante()
#End Region
#Region "Propiedades_Parametricas"
        Public Property _RegionID() As Short = -1
        Public Property _RegionNombre() As String = ""
        Public Property _PenalID() As Short = -1
        Public Property _PenalNombre() As String = ""
        Public Property _FechaVisita() As Long = 0

        '/*configuracion del modulo de visita*/
        'mas adelante, cambiar a propiedades privadas y leer directamente de la tabla 
        Public Property _RegimenTipoID As Short = -1
        Public Property _SolicitarInfoPabellon As Boolean = False
        Public Property _SolicitarAutoRegOrdinario As Boolean = False
        Public Property _SolicitarAutoRegAbogado As Boolean = False
        Public Property _HabilitarHuellaDigital As Boolean = False
        Public Property _HabilitarCapHuellaValReniec As Boolean = False
        Public Property _HabilitarInternoPJ As Boolean = False
        'reniec
        Public Property _ValidarModuloVisConReniec As Boolean = False
        Public Property _ValidarVisitanteConReniec As Boolean = False
        'migraciones
        Public Property _ValidarVisitanteConMigraciones As Boolean = False
        Public Property _ValidarModuloVisConMigraciones As Boolean = False


#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaMovimientoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwMovi
                        intValue = .SelectedRows(0).Cells("col_mov_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMovInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwMovi
                        intValue = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMovParentescoID() As Short
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_par_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Publicas"
        Public _InternoIDArray As String()
#End Region
#Region "Propiedades"
        Private Property HoraIngreso() As String = ""
        Private ReadOnly Property HoraIngresoDate() As Date
            Get
                Dim value As Date = Nothing
                If Me.HoraIngreso.Length > 3 Then
                    value = CDate(Me.HoraIngreso)
                End If
                Return value
            End Get
        End Property
        Private ReadOnly Property HoraEntero() As Integer
            Get
                Dim value As Integer = 0
                value = HoraIngresoDate.Hour
                Return value
            End Get
        End Property
        Private ReadOnly Property MinutoEntero() As Integer
            Get
                Dim value As Integer = 0
                value = HoraIngresoDate.Minute
                Return value
            End Get
        End Property
        Private ReadOnly Property FechaSalida() As Long
            Get
                Return 0
            End Get
        End Property
        Private ReadOnly Property HoraSalida() As String
            Get
                Return "00:00:00"
            End Get
        End Property
        Private Property IDParentesco() As Integer = -1
        Private Property ParentescoNombre() As String = ""
        Private Property PabellonID_Movimiento As Integer = -1
        Private ReadOnly Property MenoresCantidad() As Integer
            Get
                Dim value As Integer = 0
                value = Me.dgwMenores.RowCount
                Return value
            End Get
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        Private Property VisibleColumnasEtapa As Boolean = False
        Private Property DatosVisitante1 As String = ""
        Private Property DatosVisitante2 As String = ""
#End Region
#Region "Propiedades_Visitante"
        Private ReadOnly Property VisitanteID() As Integer
            Get
                Return Me.UscVisitante1._VisitanteIDReturn
            End Get
        End Property
        Private ReadOnly Property VisitanteApeNom() As String
            Get
                Return Me.UscVisitante1._ApellidosyNombres
            End Get
        End Property
        Private ReadOnly Property VisitanteIDTipoDocumento As Short
            Get
                Return Me.UscVisitante1._IDTipoDocumento
            End Get
        End Property
        Private ReadOnly Property VisitanteNumeroDoc() As String
            Get
                Return Me.UscVisitante1._NumeroDocumento
            End Get
        End Property
        Private ReadOnly Property VisFechaNacimiento As Long
            Get
                Return Me.UscVisitante1._FechaNacimiento
            End Get
        End Property
        Private ReadOnly Property PaseNumero() As String
            Get
                Return Me.UscVisitante1._PaseNumero
            End Get
        End Property
        Private ReadOnly Property VisitaSancion() As Boolean
            Get
                Return Me.UscVisitante1._Sancion
            End Get
        End Property
        Private ReadOnly Property VisitanteSexoID() As Integer
            Get
                Return Me.UscVisitante1._SexoID
            End Get
        End Property
        Private ReadOnly Property VisitanteSexo() As String
            Get
                Return Me.UscVisitante1._Sexo
            End Get
        End Property
        Private ReadOnly Property VisitanteValidadoReniec As Short
            Get
                Return Me.UscVisitante1._VisitanteValidadoReniec
            End Get
        End Property
        Private ReadOnly Property VisitanteIngresaPor As Short
            Get
                Return Me.UscVisitante1._VisitanteIngresaPor
            End Get
        End Property
        Private ReadOnly Property VisitanteNumeroRecaptura As Short
            Get
                Return Me.UscVisitante1._VisitanteNumeroRecaptura
            End Get
        End Property
#End Region
#Region "Propiedades_Interno"
        Private Property InternoID() As Integer = -1
        Private Property IntTipoDocumento() As String
            Get
                Return Me.txtIntTipoDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntTipoDoc.Text = value
            End Set
        End Property
        Private Property IntNumeroDocumento() As String
            Get
                Return Me.txtIntNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntNumDoc.Text = value
            End Set
        End Property
        Private Property IntApellidoPaterno() As String
            Get
                Return Me.txtIntApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntApePat.Text = value
            End Set
        End Property
        Private Property IntApellidoMaterno() As String
            Get
                Return Me.txtIntApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntApeMat.Text = value
            End Set
        End Property
        Private Property IntNombres() As String
            Get
                Return Me.txtIntNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntNom.Text = value.ToUpper
            End Set
        End Property
        Private ReadOnly Property InternoApellidosyNombres() As String
            Get
                Dim value As String = ""
                value = Me.IntApellidoPaterno & " " & Me.IntApellidoMaterno & ", " & Me.IntNombres
                Return value
            End Get
        End Property
        Private Property Edad() As String
            Get
                Return Me.txtEdad.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtEdad.Text = value.ToString
            End Set
        End Property
        Private Property SituacionJuridica() As String
            Get
                Return Me.txtSitJur.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSitJur.Text = value
            End Set
        End Property
        Private Property PabellonID() As Integer = -1
        Private Property PabellonNombre() As String
            Get
                Return Me.txtIntPab.Text.Trim.ToUpper
            End Get
            Set(ByVal value As String)
                Me.txtIntPab.Text = value.ToString.ToUpper
            End Set
        End Property
        Private Property EtapaID() As Integer = -1
        Private Property Etapa() As String
            Get
                Return Me.txtEtapa.Text.Trim.ToUpper
            End Get
            Set(ByVal value As String)
                Me.txtEtapa.Text = value.ToString.ToUpper
            End Set
        End Property
        Private Property InternoSancion() As Boolean
            Get
                Return Me.UscFotografia_2v1._PanelAutorizacion
            End Get
            Set(ByVal value As Boolean)
                Me.UscFotografia_2v1._PanelAutorizacion = value
            End Set
        End Property
        Private Property InternoFoto() As String = ""
#End Region
#Region "Propiedades_Temporales_Interno"
        Private ReadOnly Property Temporal_TipoInterno() As Short
            Get
                Dim value As Integer = -1

                If Me.objEntTempMov.Count > 0 Then

                    For Each objEnt As Entity.Visita.Movimiento In objEntTempMov
                        If objEnt.InternoID > 0 Or objEnt.IDInternoPJ Then
                            value = objEnt.TipoInterno
                            Exit For
                        End If

                    Next
                End If
                Return value
            End Get

        End Property
        Private ReadOnly Property Temporal_InternoID() As Integer
            Get
                Dim value As Integer = -1

                If Me.objEntTempMov.Count > 0 Then

                    For Each objEnt As Entity.Visita.Movimiento In objEntTempMov
                        If objEnt.InternoID > 0 Then
                            value = objEnt.InternoID
                            Exit For
                        End If

                    Next
                End If
                Return value
            End Get

        End Property
        Private ReadOnly Property Temporal_IDInternoPJ() As Integer
            Get
                Dim value As Integer = -1

                If Me.objEntTempMov.Count > 0 Then

                    For Each objEnt As Entity.Visita.Movimiento In objEntTempMov
                        If objEnt.IDInternoPJ > 0 Then
                            value = objEnt.IDInternoPJ
                            Exit For
                        End If

                    Next
                End If
                Return value
            End Get

        End Property
        Private ReadOnly Property Temporal_InternoApeNom() As String
            Get

                Dim value As String = ""

                If Me.objEntTempMov.Count > 0 Then

                    For Each objEnt As Entity.Visita.Movimiento In objEntTempMov
                        With objEnt
                            If objEnt.InternoID > 0 Or objEnt.IDInternoPJ Then
                                value = .InternoApellidosyNombresReadonly
                                Exit For
                            End If
                        End With
                    Next

                End If

                Return value
            End Get

        End Property
#End Region
#Region "Listar"
        Private Sub ListarSancionInterno(ByVal InternoID As Integer, ByVal FechaVisita As Long)

            Dim objBss As New Bussines.Visita.InternoSancion
            Me.InternoSancion = objBss.Sancion(InternoID, FechaVisita)

        End Sub

        Private Sub ListarInterno(ByVal objEntDatos As Entity.Visita.Interno)

            If objEntDatos Is Nothing Then
                Exit Sub
            End If

            If objEntDatos.Codigo < 1 Then
                Exit Sub
            End If

            With objEntDatos
                Me.InternoID = .Codigo
                Me.IntTipoDocumento = .TipoDocumentoNombre
                Me.IntNumeroDocumento = .NumeroDocumento
                Me.IntApellidoPaterno = .ApellidoPaterno
                Me.IntApellidoMaterno = .ApellidoMaterno
                Me.IntNombres = .Nombres
                Me.Edad = .Edad
                Me.SituacionJuridica = .SituacionJuridica
                Me.PabellonID = .PabellonID
                Me.PabellonNombre = .PabellonNombre
                Me.EtapaID = .EtapaID
                Me.Etapa = .EtapaNombre

                If Me.EtapaID < 1 Then
                    Me.Etapa = "S/E"
                End If

            End With

            ListarInternoFotoVersion(Me.InternoID)
            ListarSancionInterno(Me.InternoID, Me._FechaVisita)
            HabilitarDatosVisitante()

        End Sub

        Private Sub ListarInternoPJ(objEntDatos As Entity.Visita.InternoPJ)

            If objEntDatos Is Nothing Then
                Exit Sub
            End If

            If objEntDatos.Codigo < 1 Then
                Exit Sub
            End If

            With objEntDatos
                Me.IntTipoDocumento = .TipoDocumento
                Me.IntNumeroDocumento = .NumeroDocumento
                Me.IntApellidoPaterno = .PrimerApellido
                Me.IntApellidoMaterno = .SegundoApellido
                Me.IntNombres = .PreNombres
                Me.Edad = .Edad
                Me.SituacionJuridica = "S/I"
                Me.PabellonID = .IDPabellon
                Me.PabellonNombre = .Pabellon
                Me.EtapaID = -1
                Me.Etapa = ""

                If Me.EtapaID < 1 Then
                    Me.Etapa = "S/E"
                End If

            End With

            'foto de los internos pj
            Me.UscFotografia_2v1._cargarImagen(My.Resources.logo_pj02)

            HabilitarDatosVisitante()

        End Sub

        Private Sub LoadUscVisitante()

            With Me.UscVisitante1
                ._RegionID = Me._RegionID
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._PenalID
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Me._FechaVisita
                ._ValidarFechaNacimiento = True
                ._TipoVisita = Type.Enumeracion.Visita.EnumTipo.Penal
                'tabla de configuracion
                ._HabilitarHuellaDigital = Me._HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me._HabilitarCapHuellaValReniec
                'reniec
                ._ValidarModuloVisConReniec = Me._ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me._ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me._ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me._ValidarVisitanteConMigraciones
                ._LoadUsc()
            End With

        End Sub

        Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v1._showFotoInternoPrincipal(InternoID, 2)

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub
#End Region

#Region "Temporal"
#Region "Mayores"
        Private Sub Temporal_Listar()

            With Me.dgwMovi
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = Nothing
                .DataSource = objEntTempMov
            End With

        End Sub
        Public Sub _Temporal_Grabar(blnEsInternoPJ As Boolean, intIDInternoPJ As Integer)

            If Me.dgwMovi.RowCount < 1 Then
                Temporal_Grabar(blnEsInternoPJ, intIDInternoPJ)
                Me.UscVisitante1._HabilitarBotonGrabar(False)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No se puede registrar internos multiples. Elimine el interno seleccionado y repita la operacion")
            End If

        End Sub
        Private Sub Temporal_Grabar(blnEsInternoPJ As Boolean, intIDInternoPJ As Integer)

            objBssInterno = New Bussines.Visita.Interno
            Dim objEnt As New Entity.Visita.Interno

            Dim blnSalir As Boolean = False
            Dim intInternoID As Integer = -1
            Dim strApePat As String = ""
            Dim strApeMat As String = ""
            Dim strNom As String = ""
            Dim intPabID As Integer = -1
            Dim strPabNombre As String = ""
            Dim intEtapa As Integer = -1
            Dim strEtapaNombre As String = ""
            Dim bolSancion As Boolean = False

            Dim intIDRegimenVisita As Integer = -1
            Dim intIDTipoVisita = -1
            Dim intIDCalendarioDetalle As Integer = -1

            Me.HoraIngreso = Legolas.LBusiness.Globall.DateTime.HoraServer

            'internos inpe
            If blnEsInternoPJ = False Then

                'internos inpe
                For Each str As String In Me._InternoIDArray

                    objEnt = objBssInterno.Listar2(str)

                    With objEnt
                        intInternoID = .Codigo
                        strApePat = .ApellidoPaterno
                        strApeMat = .ApellidoMaterno
                        strNom = .Nombres
                        intPabID = .PabellonID
                        strPabNombre = .PabellonNombre
                        intEtapa = .EtapaID
                        strEtapaNombre = .EtapaNombre
                        bolSancion = .VisitaSancion

                        Me.PabellonNombre = objEnt.PabellonNombre
                    End With

                    'validar interno
                    If objEnt.Codigo < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha podido cargar los datos del interno. Intentelo nuevamente")
                        Exit Sub
                    End If

                    'listar los datos del interno asociados a los controles
                    ListarInterno(objEnt)
                    Dim intApeNom As String = Me.InternoApellidosyNombres

                    'validar las restriccones del visitante x interno
                    If ValidarTieneRestriccionxInterno() = True Then
                        Exit Sub
                    End If

                    'formulario parentesco
                    If Form_Parentesco(blnEsInternoPJ, Type.Enumeracion.Parentesco.TipoVisita.Familiares, _
                                       intEtapa, intInternoID, Me.VisitanteID, intApeNom) = False Then
                        blnSalir = True
                        Exit For
                    End If

                    'solicitar pabellon
                    Me.PabellonID_Movimiento = intPabID
                    Me.PabellonNombre = strPabNombre

                    If Me._SolicitarInfoPabellon = True Then

                        If Me.PabellonID < 1 Then
                            If Form_Pabellon() = False Then
                                blnSalir = True
                                Exit For
                            End If
                        End If

                    End If

                    'el interno pertenece a un regimen cerrado especial
                    If Me.EtapaID > 0 Then

                        'buscar visitas intimas                    
                        If intIDCalendarioDetalle < 1 Then
                            intIDCalendarioDetalle = Validar_RCE_Intimas(Me.IDParentesco)
                        End If

                        'buscar visitas de abogados
                        If intIDCalendarioDetalle < 1 Then

                            'si el visitante tiene mas de un parentesco. hay q recorrer x cad parentesco
                            If (Not ParentescoIDArray Is Nothing) AndAlso Me.ParentescoIDArray.Count > 1 Then

                                For i As Integer = 0 To Me.ParentescoIDArray.Count - 1
                                    intIDCalendarioDetalle = Validar_RCE_Abogado(Me.ParentescoIDArray(i))

                                    If intIDCalendarioDetalle > 0 Then
                                        Me.IDParentesco = Me.ParentescoIDArray(i)
                                        Me.ParentescoNombre = Me.ParentescoNombreArray(i)
                                        Exit For
                                    End If

                                Next

                            Else
                                'si el visitante solo tiene un parentesco
                                intIDCalendarioDetalle = Validar_RCE_Abogado(Me.IDParentesco)
                            End If

                        End If

                        'buscar visitas etapas
                        If intIDCalendarioDetalle < 1 Then

                            'si el visitante tiene mas de un parentesco. hay q recorrer x cad parentesco
                            If Me.ParentescoIDArray.Count > 1 Then

                                For i As Integer = 0 To Me.ParentescoIDArray.Count - 1
                                    intIDCalendarioDetalle = Validar_RCE_Etapas(Me.ParentescoIDArray(i))

                                    If intIDCalendarioDetalle > 0 Then
                                        Me.IDParentesco = Me.ParentescoIDArray(i)
                                        Me.ParentescoNombre = Me.ParentescoNombreArray(i)
                                        Exit For
                                    End If

                                Next
                            Else
                                'si el visitante solo tiene un parentesco
                                intIDCalendarioDetalle = Validar_RCE_Etapas(Me.IDParentesco)
                            End If

                        End If

                        'buscar las visitas extraordinarias
                        If intIDCalendarioDetalle < 1 Then
                            intIDCalendarioDetalle = Validar_RCE_ExtraOrdinario(Me.IDParentesco)
                        End If

                        If intIDCalendarioDetalle < 1 Then
                            blnSalir = True
                            Exit For
                        End If

                        objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                        objEntCalendarioDetalle = New Entity.Visita.Programacion.Calendario

                        objEntCalendarioDetalle = objBssCalendarioDetalle.Listar(intIDCalendarioDetalle)

                        With objEntCalendarioDetalle
                            intIDRegimenVisita = .RegimenVisitaID
                            intIDTipoVisita = .VisitaTipoID
                        End With

                    Else
                        'si el interno esta en regimen ordinario

                        'buscar las visitas extraordinarias
                        If intIDCalendarioDetalle < 1 Then
                            intIDCalendarioDetalle = Validar_RO_ExtraOrdinario(Me.IDParentesco)
                        End If

                        'buscar las programacion de abogados
                        If intIDCalendarioDetalle < 1 Then

                            'si el visitante tiene mas de un parentesco. hay q recorrer x cad parentesco
                            If Me.ParentescoIDArray.Count > 1 Then

                                For i As Integer = 0 To Me.ParentescoIDArray.Count - 1
                                    intIDCalendarioDetalle = Validar_RO_Abogado(Me.ParentescoIDArray(i))

                                    If intIDCalendarioDetalle > 0 Then
                                        Me.IDParentesco = Me.ParentescoIDArray(i)
                                        Me.ParentescoNombre = Me.ParentescoNombreArray(i)
                                        Exit For
                                    End If

                                Next

                            Else

                                'si el visitante solo tiene un parentesco

                                Select Case Me.IDParentesco
                                    Case Type.Enumeracion.Parentesco.ParentescoID.Abogado 'abogado

                                        intIDCalendarioDetalle = Validar_RO_Abogado(Me.IDParentesco)

                                        If intIDCalendarioDetalle < 1 Then
                                            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                                            "No existen programaciones de horario para la Visita de Abogados")
                                        End If

                                    Case Else

                                End Select

                            End If

                        End If

                        'buscar visitas ordinarias
                        If intIDCalendarioDetalle < 1 Then

                            'si el visitante tiene mas de un parentesco. hay q recorrer x cad parentesco
                            If Me.ParentescoIDArray.Count > 1 Then

                                For i As Integer = 0 To Me.ParentescoIDArray.Count - 1
                                    intIDCalendarioDetalle = Validar_RO_Ordinario(Me.ParentescoIDArray(i))

                                    If intIDCalendarioDetalle > 0 Then
                                        Me.IDParentesco = Me.ParentescoIDArray(i)
                                        Me.ParentescoNombre = Me.ParentescoNombreArray(i)
                                        Exit For
                                    End If

                                Next
                            Else
                                'si el visitante solo tiene un parentesco
                                intIDCalendarioDetalle = Validar_RO_Ordinario(Me.IDParentesco)
                            End If

                        End If

                        If intIDCalendarioDetalle < 1 Then
                            blnSalir = True
                            Exit For
                        End If

                        'leer los datos del registro de calendario detalle 
                        objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                        objEntCalendarioDetalle = New Entity.Visita.Programacion.Calendario

                        objEntCalendarioDetalle = objBssCalendarioDetalle.Listar(intIDCalendarioDetalle)

                        With objEntCalendarioDetalle
                            intIDRegimenVisita = .RegimenVisitaID
                            intIDTipoVisita = .VisitaTipoID
                        End With

                    End If

                    'grabar movimiento
                    Temporal_Grabar(blnEsInternoPJ, intInternoID, -1, strApePat, strApeMat, strNom, Me.IDParentesco, _
                    Me.ParentescoNombre, Me._FechaVisita, Me.HoraIngreso, Me.MenoresCantidad, _
                    Me.PabellonID_Movimiento, Me.PabellonNombre, intEtapa, strEtapaNombre, intIDRegimenVisita, intIDTipoVisita, _
                    intIDCalendarioDetalle)

                    Me.IDParentesco = -1
                    Me.ParentescoNombre = ""

                Next

            Else

                'internos pj
                intIDCalendarioDetalle = -1
                intIDRegimenVisita = Type.Enumeracion.Visita.RegimenVisita.PoderJudicial
                intIDTipoVisita = Type.Enumeracion.Visita.TipoVisita.Ordinario

                Dim objBssInternoPJ As New Bussines.Visita.InternoPJ
                Dim objEntInternoPj As New Entity.Visita.InternoPJ

                objEntInternoPj = objBssInternoPJ.Listar(intIDInternoPJ)

                With objEntInternoPj
                    strApePat = .PrimerApellido
                    strApeMat = .SegundoApellido
                    strNom = .PreNombres
                    intPabID = .IDPabellon
                    strPabNombre = .Pabellon

                    Me.PabellonNombre = .Pabellon
                End With

                'listar los datos del interno asociados a los controles
                ListarInternoPJ(objEntInternoPj)

                Dim intApeNom As String = strApePat & " " & strApeMat & ", " & strNom

                'formulario parentesco
                If Form_Parentesco(blnEsInternoPJ, Type.Enumeracion.Parentesco.TipoVisita.Familiares, _
                                   intEtapa, intInternoID, Me.VisitanteID, intApeNom) = False Then
                    blnSalir = True
                    Exit Sub
                End If

                'solicitar pabellon
                Me.PabellonID_Movimiento = intPabID
                Me.PabellonNombre = strPabNombre

                If Me._SolicitarInfoPabellon = True Then

                    If Me.PabellonID < 1 Then
                        If Form_Pabellon() = False Then
                            blnSalir = True
                        End If
                    End If

                End If

                'grabar movimiento
                Temporal_Grabar(blnEsInternoPJ, intInternoID, intIDInternoPJ, strApePat, strApeMat, strNom, Me.IDParentesco, _
                Me.ParentescoNombre, Me._FechaVisita, Me.HoraIngreso, Me.MenoresCantidad, _
                Me.PabellonID_Movimiento, Me.PabellonNombre, intEtapa, strEtapaNombre, intIDRegimenVisita, intIDTipoVisita, _
                intIDCalendarioDetalle)

                Me.IDParentesco = -1
                Me.ParentescoNombre = ""

            End If

            If blnSalir = True Then
                Me.IDParentesco = -1
                Me.ParentescoNombre = ""
                Me.PabellonID_Movimiento = -1
                Exit Sub
            End If

            Temporal_Listar()

        End Sub
        Private Sub Temporal_Grabar(blnEsInternoPj As Boolean, ByVal InternoID As Integer, intIDInternoPJ As Integer, _
        ByVal InternoApePat As String, ByVal InternoApeMat As String, ByVal InternoNom As String, _
        ByVal ParentescoID As Integer, ByVal ParentescoNombre As String, _
        ByVal FechaIngreso As Long, ByVal HoraIngreso As String, ByVal CantidadMenores As Integer, _
        ByVal PabellonID As Integer, ByVal PabellonNombre As String, _
        ByVal EtapaID As Integer, ByVal EtapaNombre As String, ByVal RegimenVisitaID As Integer, ByVal TipoVisitaID As Integer, _
        ByVal CalendarioDetalleID As Integer)

            If objEntTempMov.Count > 0 Then
                If objEntTempMov.Find_Interno(objEntTempMov, InternoID.ToString) = True Then
                    Exit Sub
                End If
            End If

            Dim intMenoresTipo As Integer = 1
            objEntMov = New Entity.Visita.Movimiento

            Dim intTipoInterno As Short = 1 'interno inpe

            If blnEsInternoPj = True Then
                intTipoInterno = 2
            End If

            With objEntMov
                '.Codigo = objEntMovCol.Count
                .TipoInterno = intTipoInterno
                .InternoID = InternoID
                .IDInternoPJ = intIDInternoPJ

                .InternoApePaterno = InternoApePat
                .InternoApeMaterno = InternoApeMat
                .InternoNombres = InternoNom
                .ParentescoID = ParentescoID
                .ParentescoNombre = ParentescoNombre
                '/*movimiento*/
                .FechaIngreso = FechaIngreso
                .HoraIngreso = HoraIngreso
                .MenoresTipo = intMenoresTipo
                .MenoresCantidad = CantidadMenores
                .PabellonID = PabellonID
                .PabellonNombre = PabellonNombre
                .EtapaID = EtapaID
                .EtapaNombre = EtapaNombre
                .RegimenVisitaID = RegimenVisitaID
                .TipoID = TipoVisitaID
                .CalendarioDetalleID = CalendarioDetalleID
                '/*otros*/
                .VisitaSancion = VisitaSancion
            End With
            objEntTempMov.Add(objEntMov)

        End Sub
        Private Sub Temporal_GrabarMovimientoCantidadMenores(ByVal CantMenoresEdad As Integer)

            For Each obj As Entity.Visita.Movimiento In objEntTempMov
                obj.MenoresCantidad = CantMenoresEdad
            Next

            Temporal_Listar()

        End Sub
        Private Sub Temporal_Eliminar()

            If Me.dgwMovi.RowCount > 0 Then
                objEntTempMov.Remove(Me.dgwMovi.SelectedRows(0).Index)
                Temporal_Listar()
            End If

        End Sub
#End Region
#Region "Memores"
        Private Sub Temporal_ListarMenores()

            With Me.dgwMenores
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = Nothing
                .DataSource = objEntTempMovMenor
            End With

            If Me.dgwMenores.Rows.Count > 0 Then
                Me.grbMovimiento.Height = 65
                Me.grbMenores.Visible = True
                'Me.dgwMenores.Visible = True
                Me.grbMenores.Text = "Visitas menores " & " (" & Me.MenoresCantidad.ToString & " Reg.)"
            Else
                Me.grbMenores.Visible = False
            End If

        End Sub
        Public Sub _Temporal_GrabarMenores(blnEsInternoPJ As Boolean, ByVal VisitanteIDMenor As Integer, IDParentescoVisitanteMenor As Integer, _
                                            VisitanteMenorParentescoNombre As String, IDCalendarioDetalle As Integer)

            Temporal_GrabarMenores(blnEsInternoPJ, VisitanteIDMenor, IDParentescoVisitanteMenor, VisitanteMenorParentescoNombre, IDCalendarioDetalle)

        End Sub
        Private Sub Temporal_GrabarMenores(blnEsInternoPJ As Boolean, ByVal IDVisitanteMenor As Integer, IDParentescoVisitanteMenor As Integer, _
                                           VisitanteMenorParentescoNombre As String, IDCalendarioDetalle As Integer)

            Dim intEtapa As Integer = Me.EtapaID
            Dim intInternoID As Integer = Me.InternoID
            Dim strInternoApeNom As String = Me.InternoApellidosyNombres

            If Me.VisitanteID = IDVisitanteMenor Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La Visita de Menor de Edad, no puede ser igual a la Visita de Adultos")
                Exit Sub
            End If

            'listar datos del visitante, menor de edad    
            Dim intIDTipoDocumento As Short = -1
            Dim strTipoDocNombre As String = ""
            Dim strNumDoc As String = ""
            Dim strApePat As String = ""
            Dim strApeMat As String = ""
            Dim strNom As String = ""
            Dim intEdad As Integer = -1
            Dim intSexo As Integer = -1
            Dim lngFechaNac As Long = 0
            Dim bolSancion As Boolean = False
            Dim intVisitaValReniec As Short = 0

            Dim objEnt As New Entity.Visita.Visitante
            objBssVisitante = New Bussines.Visita.Visitante
            objEnt = objBssVisitante.Listar(IDVisitanteMenor)

            intIDTipoDocumento = objEnt.TipoDocumentoID
            strTipoDocNombre = objEnt.TipoDocumentoNombre
            strNumDoc = objEnt.NumeroDocumento
            strApePat = objEnt.ApellidoPaterno
            strApeMat = objEnt.ApellidoMaterno
            strNom = objEnt.Nombres
            intEdad = objEnt.Edad
            intSexo = objEnt.SexoID
            lngFechaNac = objEnt.FechaNacimiento
            intVisitaValReniec = objEnt.VisitanteValidoReniec

            'si el menor de edad viene con el parentesco, no hay necesidad de entrar al frm_parentesco
            If IDParentescoVisitanteMenor < 1 Then

                'formulario parentesco
                Dim blnOK As Boolean = False
                blnOK = Form_Parentesco(blnEsInternoPJ, Type.Enumeracion.Parentesco.TipoVisita.MenoresEdad, _
                                        intEtapa, intInternoID, IDVisitanteMenor, strInternoApeNom)

                If blnOK = False Then
                    Exit Sub
                End If

            Else
                Me.IDParentesco = IDParentescoVisitanteMenor
                Me.ParentescoNombre = VisitanteMenorParentescoNombre
            End If

            Dim intRegimenVisitaID As Integer = -1
            Dim intTipoVisitaID As Integer = -1
            Dim intCalendarioDetalleID As Integer = -1

            'internos inpe
            If blnEsInternoPJ = False Then

                intCalendarioDetalleID = IDCalendarioDetalle

                If intCalendarioDetalleID < 1 Then

                    'buscar las programaciones
                    'validar el visitante con el calendariodetalle            
                    If Me.EtapaID > 0 Then
                        intCalendarioDetalleID = Validar_RCE_MenordeEdad(IDVisitanteMenor, intSexo, Me.IDParentesco, lngFechaNac)
                    Else

                        'buscar las visitas menores de edad ordinario
                        intCalendarioDetalleID = Validar_RO_MenordeEdad(IDVisitanteMenor, intSexo, Me.IDParentesco, lngFechaNac)

                    End If

                Else
                    'validar el calendario detalle extraordianrio si aun esta activo, y si el menor esta en la lista de autorizacion
                    intCalendarioDetalleID = Validar_RO_ExtraordinarioMenorEdad(intCalendarioDetalleID, IDVisitanteMenor, Me.IDParentesco, intSexo)
                End If

                If intCalendarioDetalleID < 1 Then
                    Me.IDParentesco = -1
                    Me.ParentescoNombre = ""
                    Exit Sub
                End If

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                objEntCalendarioDetalle = New Entity.Visita.Programacion.Calendario

                objEntCalendarioDetalle = objBssCalendarioDetalle.Listar(intCalendarioDetalleID)
                With objEntCalendarioDetalle
                    intRegimenVisitaID = .RegimenVisitaID
                    intTipoVisitaID = .VisitaTipoID
                End With

            Else
                'internos pj

                intRegimenVisitaID = Type.Enumeracion.Visita.RegimenVisita.PoderJudicial
                intTipoVisitaID = Type.Enumeracion.Visita.TipoVisita.MenorEdad
                intCalendarioDetalleID = -1

            End If

            'grabar movimientos temporal, menor de edad
            Temporal_GrabarMenores(IDVisitanteMenor, intIDTipoDocumento, strTipoDocNombre, strNumDoc, strApePat, strApeMat, strNom, lngFechaNac, intEdad, intSexo, _
            intVisitaValReniec, bolSancion, Me.IDParentesco, Me.ParentescoNombre, _
            0, Me._FechaVisita, Me.HoraIngreso, intRegimenVisitaID, intTipoVisitaID, intCalendarioDetalleID)

            Me.IDParentesco = -1
            Me.ParentescoNombre = ""

            Temporal_ListarMenores()

        End Sub
        Private Sub Temporal_GrabarMenores(ByVal VisitanteIDMenor As Integer, _
        intIDTipoDocumento As Short, ByVal strTipoDocumentoNombre As String, ByVal NumeroDocumento As String, _
        ByVal VisitanteApePat As String, ByVal VisitanteApeMat As String, ByVal VisitanteNom As String, _
        VisitanteFechaNacimiento As Long, ByVal VisitanteEdad As Integer, ByVal Sexo As Integer, intVisitanteValidoReniec As Short, VisitanteSancion As Boolean, _
        ByVal ParentescoID As Integer, _
        ByVal ParentescoNombre As String, ByVal MenoresCantidad As Integer, _
        ByVal FechaIngreso As Long, ByVal HoraIngreso As String,
        ByVal RegimenVisitaID As Integer, _
        ByVal TipoVisitaID As Integer, ByVal CalendarioDetalleID As Integer)

            If objEntTempMovMenor Is Nothing Then
                objEntTempMovMenor = New Entity.Visita.MovimientoCol
            End If

            If objEntTempMovMenor.Count > 0 Then
                If objEntTempMovMenor.Find_Visitante(objEntTempMovMenor, VisitanteIDMenor) = True Then
                    Exit Sub
                End If
            End If

            objEntMov = New Entity.Visita.Movimiento

            With objEntMov
                .Codigo = objEntTempMov.Count
                '/*visitante*/
                .VisitaID = VisitanteIDMenor
                .VisitanteIDTipoDocumento = intIDTipoDocumento
                .VisitanteTipoDocumento = strTipoDocumentoNombre
                .VisitanteNumeroDocumento = NumeroDocumento
                .VisitanteApePaterno = VisitanteApePat
                .VisitanteApeMaterno = VisitanteApeMat
                .VisitanteNombres = VisitanteNom
                .VisitanteSexoID = Sexo
                .VisitanteFechaNacimiento = VisitanteFechaNacimiento
                .VisitanteEdad = VisitanteEdad
                .VisitanteValidadoReniec = intVisitanteValidoReniec
                .TipoIngresoPor = Type.Enumeracion.Visita.Movimiento.IngresoPor.Ninguno
                '/****************/
                .ParentescoID = ParentescoID
                .ParentescoNombre = ParentescoNombre
                .FechaIngreso = FechaIngreso
                .HoraIngreso = HoraIngreso
                .PabellonID = PabellonID
                .PabellonNombre = PabellonNombre
                .RegimenVisitaID = RegimenVisitaID
                .TipoID = TipoVisitaID
                .CalendarioDetalleID = CalendarioDetalleID
                .VisitaSancion = VisitanteSancion
            End With

            objEntTempMovMenor.Add(objEntMov)

        End Sub

        Private Sub Temporal_EliminarMenores(ByVal MovimientoID As Integer)

            If Me.dgwMenores.RowCount > 0 Then
                objEntTempMovMenor.Remove(Me.dgwMenores.SelectedRows(0).Index)
                Temporal_ListarMenores()
            End If

        End Sub
#End Region
#End Region
#Region "Validar"
        Public Function Validar() As Boolean

            Dim value As Boolean = False

            'cantidad de registros
            If Me.dgwMovi.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Antes de grabar, agregue un movimiento de visitas")
                Return value
            End If

            'codigo de visitante
            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Registre el visitante")
                Return value
            End If

            'validar datos del visitante
            If Me.UscVisitante1._ValidarVisitante = False Then
                Return value
            End If

            'visitante sancion
            If Me.VisitaSancion = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Visitante no autorizado (sancionado) para realizar visitas")
                Return value
            End If

            'validar visitante menor
            If ValidarMenor() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ha ingresado un registro de un menor de edad no valido")
                Return value
            End If

            'validar interno
            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "No se ha registrado el codigo del interno (IDInterno)")
                Return value
            End If

            'validar la restriccion del visitante con el interno
            If ValidarTieneRestriccion() = True Then
                Return value
            End If

            'interno autorizado
            If Me.InternoSancion = True Then
                If Me.GrillaMovParentescoID <> 18 Then 'abogado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Interno no autorizado (sancionado) para recibir visitas")
                    Return value
                End If
            End If

            'si el interno tiene una etapa, validar con el horario
            If Me.EtapaID > 0 Then
                If Validar_RCE() = False Then
                    Return value
                End If
            End If

            'validar si la visita conviviente o conyugue ha ingresado a visitar al interno
            '***falta****

            value = True
            Return value
        End Function
        Private Function ValidarMenor() As Boolean

            Dim value As Boolean = False

            If objEntTempMovMenor IsNot Nothing Then
                If objEntTempMovMenor.Count > 0 Then

                    For Each obj As Entity.Visita.Movimiento In objEntTempMovMenor
                        If obj.VisitanteEdad > 17 Then
                            Return value
                        End If

                    Next
                End If

            End If

            value = True
            Return value

        End Function

        Private Function Validar_RCE_Intimas(ByVal ParentescoID As Integer) As Integer

            Dim value As Integer = -1

            Select Case ParentescoID
                Case Type.Enumeracion.Parentesco.ParentescoID.Conyugue, Type.Enumeracion.Parentesco.ParentescoID.Conviviente
                    'pasa
                Case Else
                    Return value
            End Select

            'verificar que tipo de clasificacion tiene el interno, si tiene alguna clasificacion aplicar las 
            'restricciones de visita caso contario pasa
            If Me.EtapaID > 0 Then

                Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Intimas

                Dim intParentesco = ParentescoID

                Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .RegimenVisitaID = intRegimenVisita
                    .TipoVisitaID = intTipoVisita
                    .EtapaID = Me.EtapaID
                    .SexoID = Me.VisitanteSexoID
                    .InternoID = Me.InternoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                    .VisitanteID = Me.VisitanteID
                    .ParentescoID = intParentesco
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            End If

            Return value

        End Function
        Private Function Validar_RCE_Etapas(ByVal ParentescoID As Integer) As Integer

            Dim value As Integer = -1

            Select Case ParentescoID

                Case Type.Enumeracion.Parentesco.ParentescoID.Abogado
                    Return value
                Case Else
                    'pasa
            End Select

            'verificar que tipo de clasificacion tiene el interno, si tiene alguna clasificacion aplicar las 
            'restricciones de visita caso contario pasa
            If Me.EtapaID > 0 Then

                Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Etapas

                Dim intParentesco = ParentescoID

                Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .RegimenVisitaID = intRegimenVisita
                    .TipoVisitaID = intTipoVisita
                    .EtapaID = Me.EtapaID
                    .SexoID = Me.VisitanteSexoID
                    .InternoID = Me.InternoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                    .VisitanteID = Me.VisitanteID
                    .ParentescoID = intParentesco
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            End If

            Return value

        End Function
        Private Function Validar_RCE_Abogado(ByVal ParentescoID As Integer) As Integer

            Dim value As Integer = -1

            Select Case ParentescoID
                Case 18 'abogado
                    'pasa
                Case Else
                    Return value
            End Select

            'verificar que tipo de clasificacion tiene el interno, si tiene alguna clasificacion aplicar las 
            'restricciones de visita caso contario pasa
            If Me.EtapaID > 0 Then

                Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Abogado

                Dim intParentesco = ParentescoID

                Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .RegimenVisitaID = intRegimenVisita
                    .TipoVisitaID = intTipoVisita
                    .EtapaID = -1
                    .SexoID = Me.VisitanteSexoID
                    .InternoID = Me.InternoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                    .VisitanteID = Me.VisitanteID
                    .ParentescoID = intParentesco
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            End If

            Return value

        End Function
        Private Function Validar_RCE_MenordeEdad_Antes(ByRef IDCalendarioDetalleExtraOrdinario As Integer) As Integer

            Dim value As Integer = -1


            'verificar que tipo de clasificacion tiene el interno, si tiene alguna clasificacion aplicar las 
            'restricciones de visita caso contario pasa
            If Me.EtapaID > 0 Then

                Dim objEntValidar As Entity.Visita.Programacion.CalendarioValidar = Nothing
                Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.Ninguno
                Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Ninguno

                'buscamos si hay programacion de extraordinarias del interno, luego buscaremos si hay menores de edad
                intRegimenVisita = Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                intTipoVisita = Type.Enumeracion.Visita.TipoVisita.Extraordinario

                objEntValidar = New Entity.Visita.Programacion.CalendarioValidar
                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .RegimenVisitaID = intRegimenVisita
                    .TipoVisitaID = intTipoVisita
                    .EtapaID = -1 'etapa no va, porque en extraordinaria se omite 
                    .SexoID = -1
                    .InternoID = Me.InternoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                    .VisitanteID = -1
                    .ParentescoID = -1
                    .ValidacionMenorAntes = True
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                IDCalendarioDetalleExtraOrdinario = objBssCalendarioDetalle.BuscarCalendario(objEntValidar, False)
                '*******************************************************************************************************

                'buscamos menores de edad, en la programacion ordinaria 
                intRegimenVisita = Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                intTipoVisita = Type.Enumeracion.Visita.TipoVisita.MenorEdad

                Dim blnMostrarMensajeMenOrdinario As Boolean = True

                If IDCalendarioDetalleExtraOrdinario > 0 Then
                    blnMostrarMensajeMenOrdinario = False
                End If

                objEntValidar = New Entity.Visita.Programacion.CalendarioValidar
                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .RegimenVisitaID = intRegimenVisita
                    .TipoVisitaID = intTipoVisita
                    .EtapaID = Me.EtapaID
                    .SexoID = -1
                    .InternoID = Me.InternoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                    .VisitanteID = -1
                    .ParentescoID = -1
                    .ValidacionMenorAntes = True
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar, blnMostrarMensajeMenOrdinario)
                '*******************************************************************************

            End If

            Return value

        End Function
        Private Function Validar_RCE_MenordeEdad(ByVal VisitanteID As Integer, ByVal VisitanteSexo As Integer, _
                                                              ByVal ParentescoID As Integer, _
                                                              FechaNacimiento As Long) As Integer

            Dim value As Integer = -1

            'verificar que tipo de clasificacion tiene el interno, si tiene alguna clasificacion aplicar las 
            'restricciones de visita caso contario pasa
            If Me.EtapaID > 0 Then

                Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.MenorEdad

                Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .RegimenVisitaID = intRegimenVisita
                    .TipoVisitaID = intTipoVisita
                    .EtapaID = Me.EtapaID
                    .SexoID = VisitanteSexo
                    .InternoID = Me.InternoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                    .VisitanteID = VisitanteID
                    .ParentescoID = ParentescoID
                    .VisitanteFechaNacimiento = FechaNacimiento
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            End If

            Return value

        End Function
        Private Function Validar_RCE_ExtraOrdinario(ByVal ParentescoID As Integer) As Integer

            Dim value As Integer = -1

            'verificar que tipo de clasificacion tiene el interno, si tiene alguna clasificacion aplicar las 
            'restricciones de visita caso contario pasa
            If Me.EtapaID > 0 Then

                Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Extraordinario

                Dim intParentesco = ParentescoID

                Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .RegimenVisitaID = intRegimenVisita
                    .TipoVisitaID = intTipoVisita
                    .EtapaID = -1
                    .SexoID = -1
                    .InternoID = Me.InternoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                    .VisitanteID = Me.VisitanteID
                    .ParentescoID = intParentesco
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            End If

            Return value

        End Function
        Private Function Validar_RCE() As Boolean

            Dim value As Boolean = False

            Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar

            For Each obj As Entity.Visita.Movimiento In objEntTempMov

                With objEntValidar
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .InternoID = obj.InternoID
                    .EtapaID = obj.EtapaID
                    .RegimenVisitaID = obj.RegimenVisitaID
                    .TipoVisitaID = obj.TipoID
                    .ParentescoID = obj.ParentescoID
                    .VisitanteID = Me.VisitanteID
                    .SexoID = Me.VisitanteSexoID
                    .Fecha = Me._FechaVisita
                    .Hora = Me.HoraEntero
                    .Minuto = Me.MinutoEntero
                End With

                objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
                value = objBssCalendarioDetalle.Validar_CalendarioID(objEntValidar, obj.CalendarioDetalleID)

                If value = False Then
                    Exit For
                End If

            Next

            Return value

        End Function

        Private Function Validar_RO_Ordinario(ByVal ParentescoID As Integer) As Integer

            Dim value As Integer = -1

            Select Case ParentescoID

                Case Type.Enumeracion.Parentesco.ParentescoID.Abogado
                    Return value
                Case Else
                    'pasa
            End Select

            Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
            Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Ordinario

            Dim intParentesco = ParentescoID

            Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
            With objEntValidar
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = intRegimenVisita
                .TipoVisitaID = intTipoVisita
                .EtapaID = -1 'sin etapa
                .SexoID = Me.VisitanteSexoID
                .InternoID = Me.InternoID
                .Fecha = Me._FechaVisita
                .Hora = Me.HoraEntero
                .Minuto = Me.MinutoEntero
                .VisitanteID = Me.VisitanteID
                .ParentescoID = intParentesco
            End With

            objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
            value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            Return value

        End Function
        Private Function Validar_RO_Abogado(ByVal ParentescoID As Integer) As Integer

            Dim value As Integer = -1

            Select Case ParentescoID
                Case Type.Enumeracion.Parentesco.ParentescoID.Abogado 'abogado
                    'pasa
                Case Else
                    Return value
            End Select

            Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
            Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Abogado

            Dim intParentesco = ParentescoID

            Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
            With objEntValidar
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = intRegimenVisita
                .TipoVisitaID = intTipoVisita
                .EtapaID = -1
                .SexoID = Me.VisitanteSexoID
                .InternoID = Me.InternoID
                .Fecha = Me._FechaVisita
                .Hora = Me.HoraEntero
                .Minuto = Me.MinutoEntero
                .VisitanteID = Me.VisitanteID
                .ParentescoID = intParentesco
            End With

            objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
            value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            Return value

        End Function
        Private Function Validar_RO_ExtraOrdinario(ByVal ParentescoID As Integer) As Integer

            Dim value As Integer = -1

            Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
            Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Extraordinario

            Dim intParentesco = ParentescoID

            Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
            With objEntValidar
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = intRegimenVisita
                .TipoVisitaID = intTipoVisita
                .EtapaID = -1
                .SexoID = -1
                .InternoID = Me.InternoID
                .Fecha = Me._FechaVisita
                .Hora = Me.HoraEntero
                .Minuto = Me.MinutoEntero
                .VisitanteID = Me.VisitanteID
                .ParentescoID = intParentesco
            End With

            objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
            value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar, False)

            Return value

        End Function
        Private Function Validar_RO_MenordeEdad_Antes(ByRef IDCalendarioDetalleExtraOrdinario As Integer) As Integer

            Dim value As Integer = -1

            Dim objEntValidar As Entity.Visita.Programacion.CalendarioValidar = Nothing
            Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario = Type.Enumeracion.Visita.RegimenVisita.Ninguno
            Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.Ninguno

            'buscamos si hay programacion de extraordinarias del interno, luego buscaremos si hay menores de edad
            intRegimenVisita = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
            intTipoVisita = Type.Enumeracion.Visita.TipoVisita.Extraordinario

            objEntValidar = New Entity.Visita.Programacion.CalendarioValidar
            With objEntValidar
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = intRegimenVisita
                .TipoVisitaID = intTipoVisita
                .EtapaID = -1
                .SexoID = -1
                .InternoID = Me.InternoID
                .Fecha = Me._FechaVisita
                .Hora = Me.HoraEntero
                .Minuto = Me.MinutoEntero
                .VisitanteID = -1
                .ParentescoID = -1
                .ValidacionMenorAntes = True
            End With

            objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
            IDCalendarioDetalleExtraOrdinario = objBssCalendarioDetalle.BuscarCalendario(objEntValidar, False)
            '*******************************************************************************************************

            'buscamos menores de edad, en la programacion ordinaria 
            intRegimenVisita = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
            intTipoVisita = Type.Enumeracion.Visita.TipoVisita.MenorEdad

            Dim blnMostrarMensajeMenOrdinario As Boolean = True

            If IDCalendarioDetalleExtraOrdinario > 0 Then
                blnMostrarMensajeMenOrdinario = False
            End If

            objEntValidar = New Entity.Visita.Programacion.CalendarioValidar
            With objEntValidar
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = intRegimenVisita
                .TipoVisitaID = intTipoVisita
                .EtapaID = Me.EtapaID
                .InternoID = Me.InternoID
                .Fecha = Me._FechaVisita
                .Hora = Me.HoraEntero
                .Minuto = Me.MinutoEntero
                .ValidacionMenorAntes = True
            End With

            objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
            value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar, blnMostrarMensajeMenOrdinario)
            '******************************************************************************************

            Return value

        End Function
        Private Function Validar_RO_MenordeEdad(ByVal VisitanteID As Integer, ByVal VisitanteSexo As Integer, _
                                                              ByVal ParentescoID As Integer, FechaNacimiento As Long) As Integer

            Dim value As Integer = -1

            Dim intRegimenVisita As Integer = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
            Dim intTipoVisita As Integer = Type.Enumeracion.Visita.TipoVisita.MenorEdad

            Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar
            With objEntValidar
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = intRegimenVisita
                .TipoVisitaID = intTipoVisita
                .EtapaID = Me.EtapaID
                .SexoID = VisitanteSexo
                .InternoID = Me.InternoID
                .Fecha = Me._FechaVisita
                .Hora = Me.HoraEntero
                .Minuto = Me.MinutoEntero
                .VisitanteID = VisitanteID
                .ParentescoID = ParentescoID
                .VisitanteFechaNacimiento = FechaNacimiento
            End With

            objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
            value = objBssCalendarioDetalle.BuscarCalendario(objEntValidar)

            Return value

        End Function
        Private Function Validar_RO_ExtraordinarioMenorEdad(IDCalendariDetalle As Integer, _
                                                            IDVisitante As Integer, _
                                                            IDParentescoVisitante As Integer, _
                                                            IDSexoVisitante As Integer) As Integer

            Dim value As Integer = -1
            Dim blnExisteProgramacion As Boolean = False

            Dim objEntValidar As New Entity.Visita.Programacion.CalendarioValidar

            With objEntValidar
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .InternoID = Me.InternoID
                .EtapaID = Me.EtapaID
                .RegimenVisitaID = Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
                .TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.Extraordinario
                .ParentescoID = IDParentesco
                .VisitanteID = IDVisitante
                .SexoID = IDSexoVisitante
                .Fecha = Me._FechaVisita
                .Hora = Me.HoraEntero
                .Minuto = Me.MinutoEntero
            End With

            objBssCalendarioDetalle = New Bussines.Visita.Programacion.CalendarioDetalle
            blnExisteProgramacion = objBssCalendarioDetalle.Validar_ExtraordinarioMenorEdad(objEntValidar, IDCalendariDetalle)

            If blnExisteProgramacion = True Then
                value = IDCalendariDetalle
            End If
            Return value
        End Function

        Private Function ValidarTieneRestriccion() As Boolean

            Dim value As Boolean = True

            If ValidarTieneRestriccionTotal() = True Then
                Return value
            End If

            If ValidarTieneRestriccionxInterno() = True Then
                Return value
            End If

            value = False
            Return value

        End Function

        Private Function ValidarTieneRestriccionTotal() As Boolean

            Dim value As Boolean = True

            Dim objEntFiltro As New Entity.Visita.VisitanteRestriccion
            With objEntFiltro
                .VisitanteID = Me.VisitanteID
                .RestriccionTipoID = 2 'restriccion al penal
                .InternoID = -1
            End With

            Dim objBss As New Bussines.Visita.VisitanteRestriccion
            value = objBss.ValidarTieneRestriccionVisitante(objEntFiltro)

            If value = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El visitante tiene restriccion al establecimiento penitenciario")
            End If

            Return value

        End Function

        Private Function ValidarTieneRestriccionxInterno() As Boolean

            Dim value As Boolean = True

            Dim objEntFiltro As New Entity.Visita.VisitanteRestriccion
            With objEntFiltro
                .VisitanteID = Me.VisitanteID
                .RestriccionTipoID = 1 'restriccion al interno
                .InternoID = Me.InternoID
                .FechaInicio = Me._FechaVisita 'Legolas.Configuration.Aplication.FechayHora.FechaLong
            End With

            Dim objBss As New Bussines.Visita.VisitanteRestriccion
            value = objBss.ValidarTieneRestriccionVisitante(objEntFiltro)

            If value = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El visitante tiene restriccion con el interno actual, seleccione otro interno")
            End If

            Return value
        End Function

#End Region
#Region "Accion"

        Public Function _AGrabar() As Boolean

            Dim value As Boolean = False
            Dim blnGraboDatosVisitante As Boolean = True

            Me.HoraIngreso = Legolas.LBusiness.Globall.DateTime.HoraServer

            If Validar() = True Then

                'falta validar si el visitante ha cambiado algo, para actualizarso sino pasa sin update
                Me.DatosVisitante2 = Me.UscVisitante1._ConcatenarPropiedadesVisitante

                If Me.DatosVisitante1 <> Me.DatosVisitante2 Then
                    blnGraboDatosVisitante = Me.UscVisitante1._GrabarVisitante()
                End If

                If blnGraboDatosVisitante = True Then
                    AGrabarMovimiento()
                    value = True
                End If

            End If

            Return value

        End Function

        Private Sub AGrabarMovimiento()

            Dim intValue As Integer = 0
            Dim blnPrimero As Boolean = True
            Dim intMovPadre As Integer = 0
            Dim intTipoMenores As Integer = 1

            objBssMovimiento = New Bussines.Visita.Movimiento

            For Each obj As Entity.Visita.Movimiento In objEntTempMov

                If blnPrimero = True Then
                    intMovPadre = 0
                Else
                    intMovPadre = intMovPadre
                End If

                With obj

                    'grabar movimiento
                    objEntMov = New Entity.Visita.Movimiento
                    With objEntMov
                        .Codigo = -1
                        .RegionID = Me._RegionID
                        .PenalID = Me._PenalID
                        .MovimientoPadre = intMovPadre
                        .PaseNumero = Me.PaseNumero
                        '/*visita*/
                        .VisitaID = Me.VisitanteID
                        .VisitanteApellidosyNombres = Me.VisitanteApeNom
                        .VisitanteIDTipoDocumento = Me.VisitanteIDTipoDocumento
                        .VisitanteNumeroDocumento = Me.VisitanteNumeroDoc
                        .VisitanteFechaNacimiento = Me.VisFechaNacimiento
                        .VisitanteValidadoReniec = Me.VisitanteValidadoReniec
                        .TipoIngresoPor = Me.VisitanteIngresaPor
                        .NumeroRecaptura = Me.VisitanteNumeroRecaptura
                        '/*internos*/
                        .TipoInterno = obj.TipoInterno
                        .InternoID = obj.InternoID
                        .IDInternoPJ = obj.IDInternoPJ
                        .InternoApellidosyNombres = obj.InternoApellidosyNombresReadonly
                        .ParentescoID = obj.ParentescoID
                        '/*movimiento*/
                        .FechaIngreso = Me._FechaVisita
                        .HoraIngreso = Me.HoraIngreso
                        .FechaSalida = Me.FechaSalida
                        .HoraSalida = Me.HoraSalida
                        '/*otros*/
                        .MenoresTipo = intTipoMenores 'tipo menores
                        .MenoresCantidad = Me.MenoresCantidad
                        .PabellonID = obj.PabellonID
                        .PabellonNombre = Me.PabellonNombre
                        .EtapaID = obj.EtapaID
                        .RegimenVisitaID = obj.RegimenVisitaID
                        .TipoID = obj.TipoID
                        .CalendarioDetalleID = obj.CalendarioDetalleID
                        .Observacion = Me.Observacion
                    End With

                    intValue = objBssMovimiento.Grabar(objEntMov)

                    'si se cambio el pabellon grabar el pabellon del interno
                    If intValue > 0 And (Me.PabellonID <> .PabellonID) Then
                        objBssInterno = New Bussines.Visita.Interno

                        Dim objEntVisita As New Entity.Visita.Interno
                        With objEntVisita
                            .Codigo = Me.InternoID
                            .PabellonID = Me.PabellonID_Movimiento
                            .IDRegion = Me._RegionID
                            .IDPenal = Me._PenalID
                        End With
                        objBssInterno.GrabarPabellon(objEntVisita)
                    End If

                End With


                If blnPrimero = True Then
                    intMovPadre = intValue
                    blnPrimero = False
                End If

            Next

            AGrabarMovimientoMenor(intMovPadre)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

                Me.UscVisitante1._ALimpiarVisitante(True)                
                ALimpiarInterno()
                ALimpiarMovimiento()

                Me.UscVisitante1._Focus()
            End If

        End Sub

        Private Sub AGrabarMovimientoMenor(ByVal MovimientoID As Integer)

            If objEntTempMovMenor Is Nothing Then
                Exit Sub
            End If

            Dim intValue As Integer = 0
            Dim intTipoMenores As Integer = 2
            Dim intMenoresCant As Integer = 0
            Dim intTipoVisitaID As Integer = 11 'menores de edad

            For Each obj As Entity.Visita.Movimiento In objEntTempMovMenor
                With obj

                    'grabar movimiento
                    objEntMov = New Entity.Visita.Movimiento
                    With objEntMov
                        .Codigo = -1
                        .RegionID = Me._RegionID
                        .PenalID = Me._PenalID
                        .MovimientoPadre = MovimientoID
                        .PaseNumero = Me.PaseNumero
                        '/*visitante*/
                        .VisitaID = obj.VisitaID
                        .VisitanteApellidosyNombres = obj.VisitanteApellidosyNombresReadonly
                        .VisitanteIDTipoDocumento = obj.VisitanteIDTipoDocumento
                        .VisitanteNumeroDocumento = obj.VisitanteNumeroDocumento
                        .VisitanteFechaNacimiento = obj.VisitanteFechaNacimiento
                        .VisitanteValidadoReniec = obj.VisitanteValidadoReniec
                        .TipoIngresoPor = obj.TipoIngresoPor
                        '/*interno*/
                        .TipoInterno = Me.Temporal_TipoInterno
                        .InternoID = Me.Temporal_InternoID
                        .IDInternoPJ = Me.Temporal_IDInternoPJ
                        .InternoApellidosyNombres = Me.Temporal_InternoApeNom
                        '/******************************/
                        .ParentescoID = obj.ParentescoID
                        '/*movimiento*/
                        .FechaIngreso = Me._FechaVisita
                        .HoraIngreso = Me.HoraIngreso
                        .FechaSalida = Me.FechaSalida
                        .HoraSalida = Me.HoraSalida
                        '/*otros*/
                        .MenoresTipo = intTipoMenores 'tipo menores
                        .MenoresCantidad = intMenoresCant
                        .PabellonID = Me.PabellonID_Movimiento
                        .PabellonNombre = Me.PabellonNombre
                        .EtapaID = Me.EtapaID
                        .RegimenVisitaID = obj.RegimenVisitaID
                        .TipoID = intTipoVisitaID
                        .CalendarioDetalleID = obj.CalendarioDetalleID
                        .Observacion = Me.Observacion
                    End With

                    objBssMovimiento = New Bussines.Visita.Movimiento
                    intValue = objBssMovimiento.Grabar(objEntMov)

                End With
            Next

            If intValue > 0 Then

            End If

        End Sub
        Public CorreoAsunto As String = ""
        Public CorreoPara As String = ""
        Public strCorreoUsuario As String = ""
        Public CorreoConcopia As String = ""
        Public strServidorCorreo As String = ""
        Public strCorreoClave As String = ""
        Private Sub GrabarInternoSeguimiento()
            Dim strMensajeError As String = ""
            EnviarCorreo(Me.CorreoPara, "", Me.CorreoAsunto, CorreoConcopia, CorreoAsunto, strMensajeError)

            If strMensajeError.Trim <> "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Se encontraron problemas al enviar al correo; " & strMensajeError)
            Else
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                'Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End Sub
        Private Function EnviarCorreo(ByVal ListaCorreoPara As String, ListaCorreoConcopia As String, ByVal Asunto As String, ByVal Mensaje As String,
        ByVal PathArchivoAdjunto As String, ByRef MensajeError As String) As Boolean

            Dim value As Boolean = False

            Try

                Dim mail As New MailMessage()
                mail.From = New MailAddress(strCorreoUsuario)

                If ListaCorreoPara.Trim.Length > 0 Then
                    mail.[To].Add(ListaCorreoPara)
                End If

                If ListaCorreoConcopia.Trim.Length > 0 Then
                    mail.[CC].Add(ListaCorreoConcopia)
                End If

                mail.Bcc.Add("desarrollo@inpe.gob.pe")

                mail.Subject = Asunto

                ' Creamos la vista para clientes que
                ' sólo pueden acceder a texto plano...

                Dim en As New System.Text.UTF8Encoding
                ' Ahora creamos la vista para clientes que 
                ' pueden mostrar contenido HTML...

                Dim strComillas As String = """"

                'Dim html As String = "<h3>" + Mensaje + "</h3>"
                Dim html As String = "<h3> <p style=" & strComillas & "color:#0A3F78" & strComillas & "> " + Mensaje + " </p> </h3>"

                'html = html + "<a href='" + Me.TextBox2.Text + "'>" + Me.TextBox1.Text + "</a><br>"

                Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, en, MediaTypeNames.Text.Html)

                ' Creamos el recurso a incrustar. Observad
                ' que el ID que le asignamos (arbitrario) está
                ' referenciado desde el código HTML como origen
                ' de la imagen (resaltado en amarillo)...

                'If PathArchivoAdjunto.Length > 0 Then
                '    html = html + "<img src='cid:imagen' />"
                '    'Dim img As New LinkedResource(PathArchivoAdjunto, TipoArchivo)
                '    Dim img As New LinkedResource(PathArchivoAdjunto, MediaTypeNames.Image.Jpeg)
                '    img.ContentId = "imagen"
                '    ' Lo incrustamos en la vista HTML...
                '    htmlView.LinkedResources.Add(img)
                'End If

                If PathArchivoAdjunto.Length > 0 Then


                    'html = html + "<img src='cid:imagen' />"
                    'Dim img As New LinkedResource(PathArchivoAdjunto, MediaTypeNames.Image.Jpeg)
                    'img.ContentId = "imagen"
                    '' Lo incrustamos en la vista HTML...
                    'htmlView.LinkedResources.Add(img)
                    Dim MyFile As String = System.IO.Path.GetFileName(PathArchivoAdjunto)
                    Dim info As New IO.FileInfo(PathArchivoAdjunto)
                    Dim attachmentFile As New Attachment(PathArchivoAdjunto)

                    mail.Attachments.Add(attachmentFile)

                End If


                ' Por último, vinculamos ambas vistas al mensaje...

                mail.AlternateViews.Add(htmlView)
                mail.IsBodyHtml = True
                ' Y lo enviamos a través del servidor SMTP...

                Dim smtp As New SmtpClient(strServidorCorreo)
                smtp.Credentials = New System.Net.NetworkCredential(strCorreoUsuario, strCorreoClave)
                smtp.Send(mail)
                value = True

            Catch ex As Exception
                MensajeError = ex.Message
                value = False
            End Try

            Return value

        End Function

#End Region
#Region "Formulario"
        Private Sub Form_Menores()

            If Me.VisitanteID < 1 Or Me.dgwMovi.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Antes de agregar menores, ingrese el Visitante e Interno")
                Me.UscVisitante1._Focus()
                Exit Sub
            End If

            Dim intIDCalendarioDetalle As Integer = -1
            Dim intIDCalendarioDetalleExtraOrdinario As Integer = -1

            If Me._HabilitarInternoPJ = False Then 'internos inpe

                'verificar si esta permitido la visita de menores de edad
                If Me.EtapaID > 0 Then

                    'validar el visitante con el calendariodetalle
                    Me.HoraIngreso = Legolas.LBusiness.Globall.DateTime.HoraServer
                    intIDCalendarioDetalle = Validar_RCE_MenordeEdad_Antes(intIDCalendarioDetalleExtraOrdinario)
                Else

                    'validar el visitante con el calendariodetalle                
                    Me.HoraIngreso = Legolas.LBusiness.Globall.DateTime.HoraServer
                    intIDCalendarioDetalle = Validar_RO_MenordeEdad_Antes(intIDCalendarioDetalleExtraOrdinario)
                End If

                If intIDCalendarioDetalle < 1 And intIDCalendarioDetalleExtraOrdinario < 1 Then
                    Exit Sub
                End If

            Else
                'internos pj
            End If

            RaiseEvent _Click_Form_Menores(Me.EtapaID, Me.VisitanteID, intIDCalendarioDetalle, intIDCalendarioDetalleExtraOrdinario)

        End Sub
        Private Sub Form_InternoPJ()

            'validar
            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Para buscar internos(as) del PJ, primero debe ingresar los datos del visitante")
                Exit Sub
            End If

            RaiseEvent _Click_Form_InternosPJ(Me.VisitanteID)

        End Sub
        Private Sub Form_Interno()

            'validar
            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Para buscar internos(as), primero debe ingresar los datos del visitante")
                Exit Sub
            End If

            RaiseEvent _Click_Form_Internos(Me.VisitanteID)

        End Sub
        Private Sub Form_InternosHistoricos()

            Dim strApellidos As String = ""
            Dim strNombres As String = ""

            'validar
            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Para buscar internos(as) visitados anteriormente, debe ingresar los datos del visitante")
                Exit Sub
            End If

            RaiseEvent _Click_Form_InternosHistoricos(Me.VisitanteID)



        End Sub
        Private Sub Form_DetalleSancion(ByVal Tipo As Integer)

            Select Case Tipo
                Case 1 'visita

                    Dim frm As New Visita.frmSancionDetallePopup
                    With frm
                        ._Codigo = Me.VisitanteID
                        ._TipoVista = frmSancionDetallePopup.enmTipo.Visitante
                        .ShowDialog()
                    End With
                Case 2 'interno
                    Dim frm As New Visita.frmSancionDetallePopup
                    With frm
                        ._Codigo = InternoID
                        ._TipoVista = frmSancionDetallePopup.enmTipo.Interno
                        .ShowDialog()
                    End With
            End Select

        End Sub
        Private Function Form_Parentesco(blnEsInternPJ As Boolean, TipoParentesco As Type.Enumeracion.Parentesco.TipoVisita, _
                                         ByVal EtapaID As Integer, ByVal InternoID As Integer, ByVal VisitanteID As Integer, _
                                         ByVal InternoApellidosyNombres As String) As Boolean

            Dim value As Boolean = False

            ParentescoIDArray = New List(Of Integer)
            ParentescoNombreArray = New List(Of String)

            'primeros buscamos el parentesco del visitante con el interno en la tabla autorizacion
            Dim objBss As Bussines.Visita.Autorizacion = Nothing
            Dim objEntCol As Entity.Visita.AutorizacionCol = Nothing
            Dim objEntFiltro As New Entity.Visita.Autorizacion

            'si el interno tiene etapa, hay q buscarlo en autorizacion
            If EtapaID > 0 Then

                objEntFiltro = New Entity.Visita.Autorizacion
                With objEntFiltro
                    .VisitanteID = VisitanteID
                    .InternoID = InternoID
                    .TipoID = 1 ' autorizado
                End With

                objBss = New Bussines.Visita.Autorizacion
                objEntCol = New Entity.Visita.AutorizacionCol

                objEntCol = objBss.ListarVisitante(objEntFiltro)

                For Each obj As Entity.Visita.Autorizacion In objEntCol
                    Me.IDParentesco = obj.ParentescoID
                    Me.ParentescoNombre = obj.Parentesco

                    'add a la colecion de parentesco
                    Me.ParentescoIDArray.Add(Me.IDParentesco)
                    Me.ParentescoNombreArray.Add(Me.ParentescoNombre)
                Next

                'si no hay ningun parentesco, lo ubicamos en la visita extraordinario
                If Me.IDParentesco < 1 Then

                    objBss = New Bussines.Visita.Autorizacion
                    objEntCol = New Entity.Visita.AutorizacionCol

                    objEntFiltro = New Entity.Visita.Autorizacion
                    With objEntFiltro
                        .VisitanteID = VisitanteID
                        .InternoID = InternoID
                        .TipoID = 99 'extraordinario
                        .Fecha = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                    End With

                    objEntCol = objBss.ListarVisitante_Extraordinario(objEntFiltro)

                    For Each obj As Entity.Visita.Autorizacion In objEntCol
                        Me.IDParentesco = obj.ParentescoID
                        Me.ParentescoNombre = obj.Parentesco
                        'add a la colecion de parentesco
                        Me.ParentescoIDArray.Add(Me.IDParentesco)
                        Me.ParentescoNombreArray.Add(Me.ParentescoNombre)
                    Next

                End If

                If Me._SolicitarAutoRegAbogado = True Then

                    'si no encuentra el parentesco en ordinario, ni extraordinario, entonces no esta autorizado
                    If Me.IDParentesco < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                                "El Visitante no esta autorizado por el interno")

                        If Me.UscVisitante1._IsVisitanteNuevo = True Then

                            objBssVisitante = New Bussines.Visita.Visitante
                            objBssVisitante.Eliminar(Me.VisitanteID)

                            Me.UscVisitante1._ALimpiarVisitante(True)
                            ALimpiarInterno()
                            ALimpiarMovimiento()
                            Me.UscVisitante1._Focus()

                        End If

                    End If

                End If

            Else

                'si el interno no es interno pj 
                If blnEsInternPJ = False Then

                    '/*ORDINARIO*/
                    If Me._SolicitarAutoRegOrdinario = True Then

                        'primeros buscamos el parentesco del visitante con el interno en la tabla autorizacion                
                        objEntFiltro = New Entity.Visita.Autorizacion
                        With objEntFiltro
                            .VisitanteID = VisitanteID
                            .InternoID = InternoID
                            .TipoID = 1 ' autorizado
                        End With

                        objBss = New Bussines.Visita.Autorizacion
                        objEntCol = New Entity.Visita.AutorizacionCol

                        objEntCol = objBss.ListarVisitante(objEntFiltro)

                        ParentescoIDArray = New List(Of Integer)
                        ParentescoNombreArray = New List(Of String)

                        For Each obj As Entity.Visita.Autorizacion In objEntCol
                            Me.IDParentesco = obj.ParentescoID
                            Me.ParentescoNombre = obj.Parentesco
                            'add a la colecion de parentesco
                            Me.ParentescoIDArray.Add(Me.IDParentesco)
                            Me.ParentescoNombreArray.Add(Me.ParentescoNombre)
                        Next

                        'si no hay ningun parentesco, lo ubicamos en la visita extraordinario-ordinario
                        If Me.IDParentesco < 1 Then

                            objEntFiltro = New Entity.Visita.Autorizacion
                            With objEntFiltro
                                .VisitanteID = VisitanteID
                                .InternoID = InternoID
                                .TipoID = 99 'extraordinario
                                .Fecha = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            End With

                            objBss = New Bussines.Visita.Autorizacion
                            objEntCol = New Entity.Visita.AutorizacionCol

                            objEntCol = objBss.ListarVisitante_Extraordinario(objEntFiltro)

                            For Each obj As Entity.Visita.Autorizacion In objEntCol
                                Me.IDParentesco = obj.ParentescoID
                                Me.ParentescoNombre = obj.Parentesco
                                'add a la colecion de parentesco
                                Me.ParentescoIDArray.Add(Me.IDParentesco)
                                Me.ParentescoNombreArray.Add(Me.ParentescoNombre)
                            Next

                        End If

                        If Me._SolicitarAutoRegAbogado = True Then

                            'si no encuentra el parentesco en ordinario, ni extraordinario, entonces no esta autorizado
                            If Me.IDParentesco < 1 Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                                        "El Visitante no esta autorizado por el interno")

                                If Me.UscVisitante1._IsVisitanteNuevo = True Then

                                    objBssVisitante = New Bussines.Visita.Visitante
                                    objBssVisitante.Eliminar(Me.VisitanteID)

                                    Me.UscVisitante1._ALimpiarVisitante(True)
                                    ALimpiarInterno()
                                    ALimpiarMovimiento()
                                    Me.UscVisitante1._Focus()

                                End If

                            End If

                        End If

                    Else

                        'si no hay ningun parentesco, lo ubicamos en la visita extraordinario-ordinario
                        If Me.IDParentesco < 1 Then

                            objEntFiltro = New Entity.Visita.Autorizacion
                            With objEntFiltro
                                .VisitanteID = VisitanteID
                                .InternoID = InternoID
                                .TipoID = 99 'extraordinario
                                .Fecha = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            End With

                            objBss = New Bussines.Visita.Autorizacion
                            objEntCol = New Entity.Visita.AutorizacionCol

                            objEntCol = objBss.ListarVisitante_Extraordinario(objEntFiltro)

                            For Each obj As Entity.Visita.Autorizacion In objEntCol
                                Me.IDParentesco = obj.ParentescoID
                                Me.ParentescoNombre = obj.Parentesco
                                'add a la colecion de parentesco
                                Me.ParentescoIDArray.Add(Me.IDParentesco)
                                Me.ParentescoNombreArray.Add(Me.ParentescoNombre)
                            Next

                        End If

                    End If

                Else

                    'si es interno pj
                    Me.IDParentesco = -1

                End If

            End If

            'formulario parentesco
            If Me.IDParentesco < 1 Then
                Dim frm As New Visita.frmParentesco
                With frm
                    ._TipoParentesco = TipoParentesco
                    ._InternoNombre = InternoApellidosyNombres.ToUpper
                    ._VisibleColumnaGrado = Me.VisibleColumnasEtapa
                    If .ShowDialog = DialogResult.OK Then
                        Me.IDParentesco = ._GrillaParentescoID
                        Me.ParentescoNombre = ._GrillaParentescoNombre
                        'add a la colecion de parentesco
                        Me.ParentescoIDArray.Add(Me.IDParentesco)
                        Me.ParentescoNombreArray.Add(Me.ParentescoNombre)
                    End If
                End With
            End If

            If Me.IDParentesco > 0 Then
                value = True
            End If

            Return value
        End Function
        Private Function Form_Pabellon() As Boolean

            Dim blnOK As Boolean = False

            Dim frm As New Visita.frmPabellonPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                If .ShowDialog = DialogResult.OK Then
                    Me.PabellonID_Movimiento = ._PabellonID
                    Me.PabellonNombre = ._PabellonNombre
                    blnOK = True
                End If
            End With

            Return blnOK

        End Function

#End Region
#Region "Permisos/Accesos"
        Private Sub RegimenTipo_Permisos()

            Dim blnMostrarColumnas As Boolean = False

            Select Case Me._RegimenTipoID
                Case 2, 3
                    blnMostrarColumnas = True
                Case Else 'ordinario

            End Select

            Me.lblEtapa.Visible = blnMostrarColumnas
            Me.txtEtapa.Visible = blnMostrarColumnas

            'Me.lblPabellon.Visible = Me._SolicitarInfoPabellon
            'Me.txtIntPab.Visible = Me._SolicitarInfoPabellon

            '/*columnas*/
            Me.col_etp_nom.Visible = blnMostrarColumnas
            'Me.col_pab_nom.Visible = Me._SolicitarInfoPabellon

            Me.VisibleColumnasEtapa = blnMostrarColumnas

            Me.btnBuscarInternosPJ.Visible = Me._HabilitarInternoPJ

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarDatosVisitante()

            Dim blnEnabledVisitante As Boolean = True

            If Me._SolicitarAutoRegOrdinario = True Then
                blnEnabledVisitante = False
            Else
                If Me.EtapaID < 1 Then
                    blnEnabledVisitante = True
                Else
                    blnEnabledVisitante = False
                End If
            End If

            Me.UscVisitante1._HabilitarDatosVisitante(blnEnabledVisitante)

        End Sub
        Public Sub _ActualizarParametricasRegionPenal()

            With Me.UscVisitante1
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegionNombre = Me._RegionNombre
                ._PenalNombre = Me._PenalNombre
                '/*tabla de configuracion del modulo de visita*/
                ._SolicitarAutoRegOrdinario = Me._SolicitarAutoRegOrdinario
                ._RegimenTipoID = Me._RegimenTipoID
                ._HabilitarHuellaDigital = Me._HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me._HabilitarCapHuellaValReniec
                'reniec
                ._ValidarModuloVisConReniec = Me._ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me._ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me._ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me._ValidarVisitanteConMigraciones
            End With

            RegimenTipo_Permisos()

        End Sub
        Private Function ValidarPropiedadesParemetricas() As Boolean

            Dim value As Boolean = False

            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "El parametro [_RegionID], no esta inicializado")
                Return value
            End If

            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "El parametro [_PenalID], no esta inicializado")
                Return value
            End If

            If Me._FechaVisita < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "El parametro [_FechaVisita], no esta inicializado")
                Return value
            End If
            value = True
            Return value

        End Function

        Public Sub _Focus()
            Me.UscVisitante1._Focus()
        End Sub
        Private Sub ALimpiarInterno()

            Me.InternoID = -1
            Me.IntTipoDocumento = ""
            Me.IntNumeroDocumento = ""
            Me.IntApellidoPaterno = ""
            Me.IntApellidoMaterno = ""
            Me.IntNombres = ""
            Me.Edad = ""
            Me.SituacionJuridica = ""
            Me.PabellonID = -1
            Me.PabellonNombre = ""
            Me.Etapa = ""
            Me.UscFotografia_2v1._Limpiar()
            Me.UscFotografia_2v1._Limpiar()

        End Sub
        Private Sub ALimpiarMovimiento()

            'limpiar el datagrid y la coleccion de movimiento
            Me.dgwMovi.DataSource = Nothing
            objEntTempMov = Nothing
            objEntTempMov = New Entity.Visita.MovimientoCol

            'limpiar el datagrid y coleccion de menores            
            Me.dgwMenores.DataSource = Nothing
            Me.grbMenores.Visible = False
            objEntTempMovMenor = Nothing
            objEntTempMovMenor = New Entity.Visita.MovimientoCol

            Me.PabellonID_Movimiento = -1
            Me.grbObs.Visible = False
            Me.Observacion = ""

            Me.grbMovimiento.Height = Me.pnlGrupos.Height

        End Sub
        Public Sub _ValoresxDefault()
            ValoresxDefault()
        End Sub
        Private Sub ValoresxDefault()

            Me.grbMenores.Visible = False

            objEntTempMov = New Entity.Visita.MovimientoCol

            Me.UscFotografia_2v1._CheckImagen = True
            Me._FechaVisita = Me._FechaVisita
            Me.grbObs.Visible = False

            Me.grbMovimiento.Height = Me.pnlGrupos.Height

            RegimenTipo_Permisos()

        End Sub
        Public Sub _LoadUsc()

            If ValidarPropiedadesParemetricas() = False Then
                Exit Sub
            End If

            'ValoresxDefault()
            LoadToolTipText()
            LoadUscVisitante()

        End Sub
        Private Sub LoadToolTipText()

            With Me.ToolTip1
                .SetToolTip(Me.btnLimpiar, "Limpiar datos del interno")
                .SetToolTip(Me.btnOtros, "Buscar Internos(as) en la Poblacion del Penal")
                .SetToolTip(Me.bntHist, "Buscar Internos(as) visitados anteriormente o Autorizados")
                .SetToolTip(Me.btnAddObs, "Agregar observacion a la visita")
                .SetToolTip(Me.btnBuscarInternosPJ, "Buscar Poblacion del Poder Judicial")
            End With

        End Sub
        Public Sub _LimpiarMovimiento()

            'si hay mas de un registro, pregunto antes de borrar la informacion
            If Me.dgwMovi.RowCount > 0 Then

                If Legolas.Configuration.Aplication.MessageBox.Question( _
                "Los datos ingresados no han sido grabados, desea grabarlos") = DialogResult.Yes Then
                    _AGrabar()
                Else

                    Me.UscVisitante1._ALimpiarVisitante(True)
                    ALimpiarInterno()
                    ALimpiarMovimiento()
                    Me.UscVisitante1._Focus()
                End If

            Else

                'caso contrario solo limpio
                Me.UscVisitante1._ALimpiarVisitante(True)
                ALimpiarInterno()
                ALimpiarMovimiento()
                Me.UscVisitante1._Focus()
            End If

        End Sub

        Private Sub VerImagenTipoDocumento(intIDTipoDocumento As Short)

            Select Case intIDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    pbTipoDocumento.Image = My.Resources.dni

                Case Type.Enumeracion.enmTipoDocumento.CE
                    pbTipoDocumento.Image = My.Resources.ce

                Case Type.Enumeracion.enmTipoDocumento.PTP
                    pbTipoDocumento.Image = My.Resources.ptp

                Case Type.Enumeracion.enmTipoDocumento.CPP
                    pbTipoDocumento.Image = My.Resources.cpp

                Case Type.Enumeracion.enmTipoDocumento.PAS
                    pbTipoDocumento.Image = My.Resources.pas

                Case Else
                    Me.pbTipoDocumento.Image = Nothing
            End Select

        End Sub
#End Region

        Private Sub dgwMovi_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellClick

            '/*iconos*/
            With Me.dgwMovi
                If e.RowIndex = -1 Then Exit Sub
                If .RowCount > 0 Then
                    '/*icono ver*/
                    Select Case e.ColumnIndex
                        Case .Columns("col_eli").Index
                            Temporal_Eliminar()
                            ALimpiarInterno()
                    End Select
                End If
            End With

            If Me.GrillaMovInternoID > 0 And e.RowIndex <> -1 Then
                'ListarInterno(Me.GrillaMovInternoID)
                'MessageBox.Show(Me.GrillaMovInternoID)

            End If

        End Sub

        Private Sub dgwMovi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwMovi.KeyDown

            If e.KeyCode = Keys.Delete Then
                Temporal_Eliminar()
                ALimpiarInterno()
            End If

        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

            Temporal_Eliminar()
            ALimpiarInterno()

        End Sub

        Private Sub bntHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntHist.Click

            Form_InternosHistoricos()

        End Sub

        Private Sub btnOtros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtros.Click

            Form_Interno()

        End Sub

        Private Sub dgwMenores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellClick

            '/*iconos*/
            With Me.dgwMenores
                If e.RowIndex = -1 Then Exit Sub
                If .RowCount > 0 Then
                    '/*icono ver*/
                    Select Case e.ColumnIndex
                        Case .Columns("col_eli_men").Index
                            Temporal_EliminarMenores(Me.GrillaMovimientoID)
                    End Select
                End If
            End With

        End Sub

        Private Sub dgwMenores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwMenores.KeyDown

            If e.KeyCode = Keys.Delete Then
                Temporal_EliminarMenores(Me.GrillaMovimientoID)
            End If

        End Sub

        Private Sub UscVisitante1__BuscarMenores() Handles UscVisitante1._Click_BuscarMenores

            Form_Menores()

        End Sub

        Private Sub UscVisitante1__Click_BuscarVisita() Handles UscVisitante1._Click_BuscarVisita

            RaiseEvent _Click_BuscarVisitante()

        End Sub

        Private Sub UscVisitante1__ListarData() Handles UscVisitante1._Click_ListarData

            Me.DatosVisitante1 = Me.UscVisitante1._ConcatenarPropiedadesVisitante
            Form_InternosHistoricos()

        End Sub

        Private Sub btnAddObs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddObs.Click

            Me.grbObs.Visible = True
            Me.txtObservacion.Focus()

        End Sub

        Private Sub UscFotografia_2v1__NoAutorizado_DoubleClick() Handles UscFotografia_2v1._NoAutorizado_DoubleClick

            Form_DetalleSancion(2)

        End Sub

        Private Sub btnBuscarInternosPJ_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarInternosPJ.Click

            Form_InternoPJ()

        End Sub

        Private Sub UscVisitante1_Load(sender As System.Object, e As System.EventArgs) Handles UscVisitante1.Load

        End Sub

        Private Sub dgwMenores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellContentClick

        End Sub

        Private Sub UscVisitante1__SelectedIndexChanged_TipoDocumento(intIDTipoDocumento As Short) Handles UscVisitante1._SelectedIndexChanged_TipoDocumento

            VerImagenTipoDocumento(intIDTipoDocumento)

        End Sub
    End Class

End Namespace