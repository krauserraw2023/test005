Namespace Visita.Programacion
    Public Class uscProgramacion2        
        Private objEnt As Entity.Visita.Programacion.CalendarioDetalle = Nothing
        Private objBss As Bussines.Visita.Programacion.CalendarioDetalle = Nothing
#Region "Eventos"
        Public Event _Click_BuscarInterno()
        Public Event _Click_AddAutorizacion()
        Public Event _Click_AnularAutorizacion(IDAutorizacion As Integer)
        Public Event _CellDoubleClick_AutorizacionGrilla(IDAutorizacion As Integer)
#End Region
#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _CalendarioID() As Integer = -1
        Public Property _RegimenVisitaID() As Integer = -1
        Public Property _TipoVisitaID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
#End Region
#Region "Propiedades"
        Private Property EtapaID() As Integer
            Get
                Return Me.cbbEtapa.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEtapa.SelectedValue = value
            End Set
        End Property
        Private Property Sexo() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbHombres.Checked = True Then
                    value = 1
                End If

                If Me.rdbMujeres.Checked = True Then
                    value = 0
                End If

                If Me.rdbSexoAmbos.Checked = True Then
                    value = 10
                End If

                Return value

            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 0
                        Me.rdbMujeres.Checked = True
                    Case 1
                        Me.rdbHombres.Checked = True
                    Case 10
                        Me.rdbSexoAmbos.Checked = True
                    Case Else
                        Me.rdbHombres.Checked = False
                        Me.rdbMujeres.Checked = False
                End Select
            End Set
        End Property
        Private Property EstadoID() As Integer = 1        
        Public Property _InternoID() As Integer = -1
        Public ReadOnly Property _FechaInicio As Long
            Get
                Return Me.FechaInicio
            End Get
        End Property

        Public Property InternoApellidosyNombres As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(value As String)
                Me.UscLabelBusqueda1._Value = value
            End Set
        End Property
#Region "Propiedades_Frecuencia"
        Private Property FechaInicio() As Long
            Get
                Return Me.UscFrecuencia1._FechaInicio
            End Get
            Set(ByVal value As Long)
                Me.UscFrecuencia1._FechaInicio = value
            End Set
        End Property
        Private Property FechaFin() As Long
            Get
                Return Me.UscFrecuencia1._FechaFin
            End Get
            Set(ByVal value As Long)
                Me.UscFrecuencia1._FechaFin = value
            End Set
        End Property
        Private Property Anio() As Integer
            Get
                Return Me.UscFrecuencia1._Anio
            End Get
            Set(value As Integer)
                Me.UscFrecuencia1._Anio = value
            End Set
        End Property
        Private Property FechaFinIndeterminado() As Boolean
            Get
                Return Me.UscFrecuencia1._Indeterminado
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._Indeterminado = value
            End Set
        End Property
        Private Property FrecuenciaID() As Integer
            Get
                Return Me.UscFrecuencia1._Frecuencia
            End Get
            Set(ByVal value As Integer)
                Me.UscFrecuencia1._Frecuencia = value
            End Set
        End Property
        Private Property FrecuenciaRepeticion() As Integer
            Get
                Return Me.UscFrecuencia1._FrecuenciaRepeticion
            End Get
            Set(ByVal value As Integer)
                Me.UscFrecuencia1._FrecuenciaRepeticion = value
            End Set
        End Property
        Private Property DiaLunes() As Boolean
            Get
                Return Me.UscFrecuencia1._DiaSemanaLunes
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._DiaSemanaLunes = value
            End Set
        End Property
        Private Property DiaMartes() As Boolean
            Get
                Return Me.UscFrecuencia1._DiaSemanaMartes
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._DiaSemanaMartes = value
            End Set
        End Property
        Private Property DiaMiercoles() As Boolean
            Get
                Return Me.UscFrecuencia1._DiaSemanaMiercoles
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._DiaSemanaMiercoles = value
            End Set
        End Property
        Private Property DiaJueves() As Boolean
            Get
                Return Me.UscFrecuencia1._DiaSemanaJueves
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._DiaSemanaJueves = value
            End Set
        End Property
        Private Property DiaViernes() As Boolean
            Get
                Return Me.UscFrecuencia1._DiaSemanaViernes
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._DiaSemanaViernes = value
            End Set
        End Property
        Private Property DiaSabado() As Boolean
            Get
                Return Me.UscFrecuencia1._DiaSemanaSabado
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._DiaSemanaSabado = value
            End Set
        End Property
        Private Property DiaDomingo() As Boolean
            Get
                Return Me.UscFrecuencia1._DiaSemanaDomingo
            End Get
            Set(ByVal value As Boolean)
                Me.UscFrecuencia1._DiaSemanaDomingo = value
            End Set
        End Property
        Private Property MesArray() As String
            Get
                Return Me.UscFrecuencia1._MensualMesID
            End Get
            Set(ByVal value As String)
                Me.UscFrecuencia1._MensualMesID = value
            End Set
        End Property
        Private Property MesTipo() As Integer
            Get
                Return Me.UscFrecuencia1._MensualMesTipo
            End Get
            Set(ByVal value As Integer)
                Me.UscFrecuencia1._MensualMesTipo = value
            End Set
        End Property
        Private Property MesDiasArray() As String
            Get
                Return Me.UscFrecuencia1._MensualDiasID
            End Get
            Set(ByVal value As String)
                Me.UscFrecuencia1._MensualDiasID = value
            End Set
        End Property
        Private Property MesElArray() As String
            Get
                Return Me.UscFrecuencia1._MensualElID
            End Get
            Set(ByVal value As String)
                Me.UscFrecuencia1._MensualElID = value
            End Set
        End Property
        Private Property MesDiaSemanaArray() As String
            Get
                Return Me.UscFrecuencia1._MensualDiaSemanaID
            End Get
            Set(ByVal value As String)
                Me.UscFrecuencia1._MensualDiaSemanaID = value
            End Set
        End Property
#End Region
#Region "Propiedades_LimiteVisita/Parentesco"
        Private Property LimiteVisita() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._LimiteVisita
            End Get
            Set(ByVal value As Boolean)
                Me.UscProgramacionOrdinario1._LimiteVisita = value
            End Set
        End Property
        Private Property LimiteVisitaCantidad As Integer
            Get
                Return Me.UscProgramacionOrdinario1._LimiteVisitaCantidad
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._LimiteVisitaCantidad = value
            End Set
        End Property
        Private Property FamiliarConsaguidad() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._FamiliarConsaguidad
            End Get
            Set(ByVal value As Boolean)
                Me.UscProgramacionOrdinario1._FamiliarConsaguidad = value
            End Set
        End Property
        Private Property FamiliarConsanguidadCantidad() As Integer
            Get
                Return Me.UscProgramacionOrdinario1._FamiliarConsanguidadCantidad
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._FamiliarConsanguidadCantidad = value
            End Set
        End Property
        Private Property FamiliarConsanguidadGrado() As Integer
            Get
                Return Me.UscProgramacionOrdinario1._FamiliarConsanguidadGrado
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._FamiliarConsanguidadGrado = value
            End Set
        End Property
        Private Property FamiliarAfinidad() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._FamiliarAfinidad
            End Get
            Set(ByVal value As Boolean)
                Me.UscProgramacionOrdinario1._FamiliarAfinidad = value
            End Set
        End Property
        Private Property FamiliarAfinidadCantidad() As Integer
            Get
                Return Me.UscProgramacionOrdinario1._FamiliarAfinidadCantidad
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._FamiliarAfinidadCantidad = value
            End Set
        End Property
        Private Property FamiliarAfinidadGrado() As Integer
            Get
                Return Me.UscProgramacionOrdinario1._FamiliarAfinidadGrado
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._FamiliarAfinidadGrado = value
            End Set
        End Property
        Private Property IncluyeConyugueConcubina() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._IncluyeConyugueConcubina
            End Get
            Set(ByVal value As Boolean)
                Me.UscProgramacionOrdinario1._IncluyeConyugueConcubina = value
            End Set
        End Property
        Private Property IncluyeAmigos() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._IncluyeAmigos
            End Get
            Set(ByVal value As Boolean)
                Me.UscProgramacionOrdinario1._IncluyeAmigos = value
            End Set
        End Property
        Private Property IncluyeAbogados() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._IncluyeAbogados
            End Get
            Set(ByVal value As Boolean)
                Me.UscProgramacionOrdinario1._IncluyeAbogados = value
            End Set
        End Property
        Private Property VisitanteRegistrado() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._RegistradoPreviamente
            End Get
            Set(ByVal value As Boolean)
                Me.UscProgramacionOrdinario1._RegistradoPreviamente = value
            End Set
        End Property
        Private Property HabilitarEdad() As Boolean
            Get
                Return Me.UscProgramacionOrdinario1._HabilitarRangoEdades
            End Get
            Set(value As Boolean)
                Me.UscProgramacionOrdinario1._HabilitarRangoEdades = value
            End Set
        End Property
        Private Property EdadInicio() As Short
            Get
                Return Me.UscProgramacionOrdinario1._EdadIni
            End Get
            Set(ByVal value As Short)
                Me.UscProgramacionOrdinario1._EdadIni = value
            End Set
        End Property
        Private Property EdadFin() As Short
            Get
                Return Me.UscProgramacionOrdinario1._EdadFin
            End Get
            Set(ByVal value As Short)
                Me.UscProgramacionOrdinario1._EdadFin = value
            End Set
        End Property
#End Region
#Region "Propiedades_Tiempo/Duracion"
        Private Property HoraInicio() As Integer
            Get
                Return Me.UscProgramacionOrdinario1._HoraMinutoInicio
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._HoraMinutoInicio = value
            End Set
        End Property
        Private Property HoraFin() As Integer
            Get
                Return Me.UscProgramacionOrdinario1._HoraMinutoFin
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._HoraMinutoFin = value
            End Set
        End Property
        Private Property Duracion() As Integer
            Get
                Return Me.UscProgramacionOrdinario1._Duracion
            End Get
            Set(ByVal value As Integer)
                Me.UscProgramacionOrdinario1._Duracion = value
            End Set
        End Property
#End Region
#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.cbbEtapa
                ._LoadUsc(Type.Combo.ComboTipo.VIS_Etapa)
            End With

        End Sub
#End Region
#Region "Listar"

        Private Sub ListarMant()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.Programacion.CalendarioDetalle
            objEnt = New Entity.Visita.Programacion.CalendarioDetalle

            objEnt = objBss.Listar(Me._Codigo)

            With objEnt
                Me._CalendarioID = .CalendarioID
                Me._RegimenVisitaID = .RegimenVisitaID
                Me._TipoVisitaID = .VisitaTipoID
                Me.EtapaID = .EtapaID
                Me.Sexo = .SexoID

                'visita-extraordinario
                If Me._TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.Extraordinario Then
                    Me._InternoID = .InternoID
                    Me.InternoApellidosyNombres = .InternoApellidosyNombres

                    ListarAutorizacion(Me._InternoID)

                End If

                '/*calendario*/
                Me.FechaInicio = .FechaInicio
                Me.FechaFin = .FechaFin
                Me.FechaFinIndeterminado = .FechaFinIndeterminado
                Me.Anio = Legolas.Components.FechaHora.FechaAnio(Me.FechaInicio)
                Me.FrecuenciaID = .FrecuenciaID
                Me.FrecuenciaRepeticion = .FrecuenciaRepeticion
                Me.DiaLunes = .DiaLunes
                Me.DiaMartes = .DiaMartes
                Me.DiaMiercoles = .DiaMiercoles
                Me.DiaJueves = .DiaJueves
                Me.DiaViernes = .DiaViernes
                Me.DiaSabado = .DiaSabado
                Me.DiaDomingo = .DiaDomingo
                Me.MesArray = .MesArray
                Me.MesTipo = .MesTipo
                Me.MesDiasArray = .MesDiaArray
                Me.MesElArray = .MesElArray
                Me.MesDiaSemanaArray = .MesDiaSemanaArray
                Me.HoraInicio = .HoraInicio
                Me.HoraFin = .HoraFin
                Me.Duracion = .Duracion
                '/********************/
                Me.LimiteVisita = .LimiteVisita
                Me.LimiteVisitaCantidad = .LimiteVisitaCantidad
                Me.FamiliarConsaguidad = .FamiliaConsanguidad
                Me.FamiliarConsanguidadCantidad = .FamiliaConsanguidadCantidad
                Me.FamiliarConsanguidadGrado = .FamiliaConsanguidadGrado
                Me.FamiliarAfinidad = .FamiliaAfinidad
                Me.FamiliarAfinidadCantidad = .FamiliaAfinidadCantidad
                Me.FamiliarAfinidadGrado = .FamiliaAfinidadGrado

                '/*edad*/
                Me.HabilitarEdad = .HabilitarRangoEdad
                Me.EdadInicio = .EdadInicio
                Me.EdadFin = .EdadFin

                Me.IncluyeConyugueConcubina = .IncluyeConyugueConcubina
                Me.IncluyeAmigos = .IncluyeAmigo
                Me.IncluyeAbogados = .IncluyeAbogado
                Me.VisitanteRegistrado = .VisitanteRegistradoPreviamente
                Me.EstadoID = .DetalleEstado
            End With

            Me.UscFrecuencia1._HabilitarDiaElDiaSemana()

            Select Case Me._TipoVisitaID
                Case 5, 11
                    'no se habilita la fecha fin, indeterminado
                Case Else
                    Me.UscFrecuencia1._HabilitarIndeterminado()
            End Select

            Me.UscFrecuencia1._HabilitarFechaIniFin()

        End Sub
        Public Sub _Listar()

            ListarMant()

        End Sub
        Private Sub ListarAutorizacion(InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.FechaInicio < 1 Then
                Exit Sub
            End If

            With Me.UscAutorizacionGrilla1
                ._IDCalendarioDetalle = Me._Codigo
                ._IDInterno = InternoID
                ._InternoApeNom = Me.InternoApellidosyNombres
                ._LoasUsc()
            End With

        End Sub
        Public Sub _ListarAutorizacion(InternoID As Integer)

            ListarAutorizacion(InternoID)

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            Dim value As Boolean = False

            'fecha inicio
            If Me.FechaInicio < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Ingrese la fecha de inicio")
                Return value
            End If

            'fecha fin
            If Me.FechaFinIndeterminado = False Then
                If Me.FechaFin < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese la fecha de fin")
                    Return value
                End If

                'la fecha fin no puede ser mayor a la fecha ini
                If Me.FechaFin < Me.FechaInicio Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La fecha fin, no puede ser menor a la fecha inicio")
                    Return value
                End If
            End If

            'validar el id del interno
            Select Case Me._TipoVisitaID
                Case 10 'extraordinario

                    If Me._InternoID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Seleccione el interno")
                        Return value
                    End If
            End Select

            value = True
            Return value
        End Function
        Private Function AGrabar() As Integer

            If Me.UscFrecuencia1._Validar() = False OrElse Validar() = False OrElse Me.UscProgramacionOrdinario1._Validar = False Then
                Exit Function
            End If

            'calcular la duracion - detalle
            Me.UscProgramacionOrdinario1._CalcularDuracion()

            objEnt = New Entity.Visita.Programacion.CalendarioDetalle
            With objEnt
                .CalendarioDetalleID = Me._Codigo
                .CalendarioID = Me._CalendarioID
                .RegimenVisitaID = Me._RegimenVisitaID
                .VisitaTipoID = Me._TipoVisitaID
                .EtapaID = Me.EtapaID
                .SexoID = Me.Sexo
                .InternoID = Me._InternoID
                .InternoApellidosyNombres = Me.InternoApellidosyNombres
                .FechaInicio = Me.FechaInicio
                .FechaFin = Me.FechaFin
                .FechaFinIndeterminado = Me.FechaFinIndeterminado
                'calendario
                .FrecuenciaID = Me.FrecuenciaID
                .FrecuenciaRepeticion = Me.FrecuenciaRepeticion
                .DiaLunes = Me.DiaLunes
                .DiaMartes = Me.DiaMartes
                .DiaMiercoles = Me.DiaMiercoles
                .DiaJueves = Me.DiaJueves
                .DiaViernes = Me.DiaViernes
                .DiaSabado = Me.DiaSabado
                .DiaDomingo = Me.DiaDomingo
                .MesArray = Me.MesArray
                .MesTipo = Me.MesTipo
                .MesDiaArray = Me.MesDiasArray
                .MesElArray = Me.MesElArray
                .MesDiaSemanaArray = Me.MesDiaSemanaArray
                '/**********************/
                .LimiteVisita = Me.LimiteVisita
                .LimiteVisitaCantidad = Me.LimiteVisitaCantidad
                .FamiliaConsanguidad = Me.FamiliarConsaguidad
                .FamiliaConsanguidadCantidad = Me.FamiliarConsanguidadCantidad
                .FamiliaConsanguidadGrado = Me.FamiliarConsanguidadGrado
                .FamiliaAfinidad = Me.FamiliarAfinidad
                .FamiliaAfinidadCantidad = Me.FamiliarAfinidadCantidad
                .FamiliaAfinidadGrado = Me.FamiliarAfinidadGrado
                .HabilitarRangoEdad = Me.HabilitarEdad
                .EdadInicio = Me.EdadInicio
                .EdadFin = Me.EdadFin
                .IncluyeConyugueConcubina = Me.IncluyeConyugueConcubina
                .IncluyeAmigo = Me.IncluyeAmigos
                .IncluyeAbogado = Me.IncluyeAbogados
                .VisitanteRegistradoPreviamente = Me.VisitanteRegistrado
                .HoraInicio = Me.HoraInicio
                .HoraFin = Me.HoraFin
                .Duracion = Me.Duracion
                .DetalleEstado = Me.EstadoID
                'region/penal
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            Dim value As Integer = -1

            objBss = New Bussines.Visita.Programacion.CalendarioDetalle
            value = objBss.Grabar(objEnt)

            If value > 0 Then
                Me._Codigo = value
                AGrabarDetalleVisitaExtraordinario()
            End If

            Return value

        End Function
        Private Sub AGrabarDetalleVisitaExtraordinario()

            'si es extraordinario, actualiza los datos con la del interno
            If _TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.Extraordinario Then

                With Me.UscAutorizacionGrilla1
                    ._IDCalendarioDetalle = Me._Codigo
                    ._IDInterno = Me._InternoID
                    ._InternoApeNom = Me.InternoApellidosyNombres
                    ._AGrabarGrilla()
                End With

            End If            

        End Sub
        Public Function _AGrabar() As Integer

            Return AGrabar()

        End Function
#End Region
#Region "Otros"
        Public Sub _LoadUsc()

            ValoresxDefault()

            Me.UscFrecuencia1._Frecuencia = Type.Enumeracion.Visita.Frecuencia.Semanal
            Me.UscFrecuencia1._LoadUsc()
            HabilitarFrecuencia()

            Me.UscProgramacionOrdinario1._LoadUsc()           

            Me.VisitanteRegistrado = True
            VisibleTipoVisita()

            'validar la busqueda de internos en la sede central
            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central
                    Me.UscLabelBusqueda1._Visible_Buscar = False
            End Select

        End Sub
        Private Sub ValoresxDefault()

            Combo()

        End Sub
        Private Sub HabilitarFrecuencia()

            Select Case Me._TipoVisitaID
                Case Type.Enumeracion.Visita.TipoVisita.Intimas   'intimas 
                    Me.UscFrecuencia1._Frecuencia = 3 'mensual
                    Me.UscFrecuencia1.rdbDiariamente.Enabled = False
                    Me.UscFrecuencia1.rdbSemanalmente.Enabled = False

                Case Type.Enumeracion.Visita.TipoVisita.Extraordinario   'extra-ordinario

                    Me.UscFrecuencia1._Frecuencia = 1 'diario
                    Me.UscFrecuencia1.rdbSemanalmente.Enabled = False
                    Me.UscFrecuencia1.rdbMensualmente.Enabled = False
                    'blnEnableFechas = True

                Case Type.Enumeracion.Visita.TipoVisita.MenorEdad   'menores de edad
                    Me.UscFrecuencia1._Frecuencia = 3 'mensual
                    Me.UscFrecuencia1.rdbDiariamente.Enabled = False
                    'Me.UscFrecuencia1.rdbSemanalmente.Enabled = False

                Case Else
                    Me.UscFrecuencia1.rdbDiariamente.Enabled = False                    
                    'blnEnableFechas = True
            End Select

        End Sub

        Private Sub VisibleTipoVisita()

            Dim blnVisibleVisitaNormal As Boolean = False
            Dim blnVisibleVisitaExtra As Boolean = False            
            Dim blnVisibleSexoAmbos As Boolean = False
            Dim blnVisibleEtapa As Boolean = False
            Dim blnVisibleEdad As Boolean = False

            Select Case Me._TipoVisitaID
                Case 2, 13 'ordinario, etapas
                    blnVisibleVisitaNormal = True
                    blnVisibleEtapa = True
                    Me.UscProgramacionOrdinario1._VisiblePanelIncluye(True, True, False)

                Case 5 'intimas

                    blnVisibleVisitaNormal = True
                    blnVisibleEtapa = True
                    blnVisibleSexoAmbos = True

                    Me.UscProgramacionOrdinario1._VisiblePanelParentesco(False)
                    Me.UscProgramacionOrdinario1._LimiteVisita = True
                    Me.UscProgramacionOrdinario1._LimiteVisitaCantidad = 1
                    Me.UscProgramacionOrdinario1.pnlLimite.Enabled = False

                    Me.UscProgramacionOrdinario1._VisiblePanelIncluye(True, False, False)                    
                    Me.UscProgramacionOrdinario1._CheckPanelIncluye(True, False, False)
                    Me.UscProgramacionOrdinario1._EnabledPanelIncluye(False, False, False)

                Case 10 'extra-ordinario

                    blnVisibleVisitaExtra = True
                    blnVisibleEtapa = False

                    Me.EtapaID = -1
                    Me.Sexo = -1

                    Me.UscProgramacionOrdinario1._VisiblePanelParentesco(False)
                    Me.UscProgramacionOrdinario1.chkRegistradoPreviamente.Checked = True
                    Me.UscProgramacionOrdinario1.chkRegistradoPreviamente.Enabled = False

                    Me.UscProgramacionOrdinario1._VisiblePanelIncluye(False, False, False)

                Case 11 'menores de edad
                    blnVisibleVisitaNormal = True
                    blnVisibleEtapa = True
                    blnVisibleSexoAmbos = True
                    blnVisibleEdad = True
                    Me.UscProgramacionOrdinario1._VisiblePanelIncluye(False, False, False)
                    Me.UscProgramacionOrdinario1.grbEdad.Visible = True

                Case 12 'abogados
                    blnVisibleVisitaNormal = True
                    blnVisibleEtapa = False
                    blnVisibleSexoAmbos = True

                    Me.EtapaID = -1

                    Me.UscProgramacionOrdinario1._VisiblePanelParentesco(False)

                    Me.UscProgramacionOrdinario1._VisiblePanelIncluye(False, False, True)
                    Me.UscProgramacionOrdinario1._CheckPanelIncluye(False, False, True)
                    Me.UscProgramacionOrdinario1._EnabledPanelIncluye(False, False, False)
            End Select

            Select Case Me._RegimenVisitaID
                Case 1 'reg. ordinario, 
                    blnVisibleEtapa = False
                Case 2 'reg. cerrado especial, 

            End Select

            Me.pnlVisitaNormal.Visible = blnVisibleVisitaNormal
            Me.pnlVisitaExtraordinario.Visible = blnVisibleVisitaExtra
            Me.rdbSexoAmbos.Visible = blnVisibleSexoAmbos
            Me.gb_SelectEtapa.Visible = blnVisibleEtapa
            Me.UscProgramacionOrdinario1.grbEdad.Visible = blnVisibleEdad

            If blnVisibleEtapa = False Then
                Me.EtapaID = -1
            End If

        End Sub

#End Region

        Private Sub cbbEtapa__SelectedIndexChanged() Handles cbbEtapa._SelectedIndexChanged

            Me.grbEtapa.Text = Me.cbbEtapa.Text.ToUpper

        End Sub

        Private Sub UscLabelBusqueda1__Click_Buscar() Handles UscLabelBusqueda1._Click_Buscar

            RaiseEvent _Click_BuscarInterno()

        End Sub

        Private Sub UscLabelBusqueda1__KeyDown_Suprimir() Handles UscLabelBusqueda1._KeyDown_Suprimir

            Me._InternoID = -1

        End Sub

        Private Sub btnAddAutorizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAutorizacion.Click

            RaiseEvent _Click_AddAutorizacion()

        End Sub

        Private Sub btnAnularAutorizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnAnularAutorizacion.Click

            RaiseEvent _Click_AnularAutorizacion(Me.UscAutorizacionGrilla1._IDGrilla)


        End Sub

        Private Sub UscLabelBusqueda1_Load(sender As System.Object, e As System.EventArgs) Handles UscLabelBusqueda1.Load

        End Sub

        Private Sub UscAutorizacionGrilla1__CellDoubleClick(IDAutorizacion As Integer) Handles UscAutorizacionGrilla1._CellDoubleClick

            RaiseEvent _CellDoubleClick_AutorizacionGrilla(IDAutorizacion)

        End Sub
    End Class

End Namespace
