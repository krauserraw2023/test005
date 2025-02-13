'Imports System.Reflection
Namespace Visita
    Public Class Movimiento
        Inherits Auditoria.Transaccion
#Region "Propiedades"

        Public Property Codigo() As Integer = -1
        Public Property RegionID() As Short = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalID() As Short = -1
        Public Property PenalNombre() As String = ""
        Public Property MovimientoPadre() As Integer = -1
        Public Property VisitaID() As Integer = -1
        Public Property FechaIngreso() As Long = 0
        Public ReadOnly Property FechaIngresoDate() As Date
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaIngreso)
            End Get
        End Property
        Public Property HoraIngreso() As String = ""
        Public Property FechaVerificacion As Long = 0
        Public Property HoraVerificacion = ""
        Public Property FechaSalida() As Long = 0

        Public ReadOnly Property FechaSalidaDate() As Date
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaSalida)
            End Get
        End Property
        Public ReadOnly Property FechaSalidaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaSalida)
            End Get
        End Property
        Public Property HoraSalida() As String = ""
        Public Property EstadoID() As Short = -1
        Public Property MenoresCantidad() As Short = 0

        Public ReadOnly Property MenoresCantidadString() As String
            Get
                Dim value As String = ""

                If Me.MenoresCantidad > 0 Then
                    value = Me.MenoresCantidad
                End If

                Return value

            End Get
        End Property
        Public Property MenoresTipo() As Short = -1

        Public Property VisitanteEdad() As Short = 0

        Public ReadOnly Property VistanteEdadstr() As String
            Get
                Dim value As String = "0"

                If VisitanteEdad > 0 Then
                    value = VisitanteEdad
                End If
                Return value
            End Get
        End Property
        Public Property PabellonID() As Integer = -1
        Public Property PabellonNombre() As String = ""
        Public Property RegimenVisitaID() As Short = -1
        Public ReadOnly Property RegimenVisitaNombreReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.RegimenVisitaID
                    Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
                        value = "Regimen Ordinario"
                    Case Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                        value = "Regimen Cerrado Especial"
                    Case Type.Enumeracion.Visita.RegimenVisita.Administrativa
                        value = "Administrativa"
                    Case Type.Enumeracion.Visita.RegimenVisita.PoderJudicial
                        value = "Poder Judicial"
                End Select
                Return value
            End Get
        End Property
        Public ReadOnly Property RegimenVisitaNombreCortoReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.RegimenVisitaID
                    Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
                        value = "R.O."
                    Case Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                        value = "R.C.E."
                    Case Type.Enumeracion.Visita.RegimenVisita.Administrativa
                        value = "ADM"
                    Case Type.Enumeracion.Visita.RegimenVisita.PoderJudicial
                        value = "PJ"
                    Case Else
                        value = "NINGUNO"
                End Select
                Return value
            End Get
        End Property

        Public Property TipoID() As Short = -1

        Public Property TipoNombre() As String = ""

        Public ReadOnly Property VisitaTipoNombreReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.TipoID
                    Case Type.Enumeracion.Visita.TipoVisita.Ordinario
                        value = "Ordinario"
                    Case Type.Enumeracion.Visita.TipoVisita.Intimas
                        value = "Intimas"
                    Case Type.Enumeracion.Visita.TipoVisita.Extraordinario
                        value = "Extraordinaria"
                    Case Type.Enumeracion.Visita.TipoVisita.MenorEdad
                        value = "Menor de edad"
                    Case Type.Enumeracion.Visita.TipoVisita.Abogado
                        value = "Abogado(a)"
                    Case Type.Enumeracion.Visita.TipoVisita.Etapas
                        value = "Etapas"                    
                End Select

                Return value

            End Get
        End Property
        Public ReadOnly Property VisitaTipoNombreCortoReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.TipoID
                    Case Type.Enumeracion.Visita.TipoVisita.Ordinario
                        value = "ORD."
                    Case Type.Enumeracion.Visita.TipoVisita.Intimas
                        value = "INTI."
                    Case Type.Enumeracion.Visita.TipoVisita.Extraordinario
                        value = "EXTR."
                    Case Type.Enumeracion.Visita.TipoVisita.MenorEdad
                        value = "MEN.E."
                    Case Type.Enumeracion.Visita.TipoVisita.Abogado
                        value = "ABOG."
                    Case Type.Enumeracion.Visita.TipoVisita.Etapas
                        value = "ETP."                    
                End Select

                Return value

            End Get
        End Property
        Public Property EtapaID() As Short = -1
        Public Property EtapaNombre() As String = ""
        Public Property CalendarioDetalleID() As Integer = -1
        Public Property ParentescoID() As Short = -1
        Public Property ParentescoNombre() As String = ""
        Public Property ParentescoTipo As Short = -1
        Public Property ParentescoGrado As Integer = -1
        Public Property PaseNumero() As String = ""

        Public ReadOnly Property Permanencia() As String
            Get
                Dim value As String = ""

                If FechaSalida > 0 Then

                    Dim day1 As DateTime = CDate(Me.FechaIngresoDate.ToShortDateString + " " + Me.HoraIngreso)
                    Dim day2 As DateTime = CDate(Me.FechaSalidaDate.ToShortDateString + " " + Me.HoraSalida)

                    Dim intMinutos As Integer = 0
                    Dim intHoras As Integer = 0
                    Dim decMin As Decimal = 0

                    '_h = DateDiff(DateInterval.Hour, day1, day2)
                    intMinutos = DateDiff(DateInterval.Minute, day1, day2)

                    If intMinutos > 60 Then
                        intHoras = intMinutos \ 60
                        decMin = Decimal.Round(((intMinutos / 60) - intHoras) * 60)
                    Else
                        decMin = Decimal.Round(intMinutos)
                    End If

                    value = intHoras.ToString + " H " + decMin.ToString + " m"
                End If

                Return value
            End Get

        End Property

        Public Property Observacion As String = ""
        Public Property ObservacionSalida As String = ""

        Public Property IDUsuarioAutorizaSalida As Integer = -1
        Public Property UsuarioAutorizaSalida As String = ""
        Public Property IDUsuarioAutorizaSalidaSinHuella As Integer = -1
        Public Property UsuarioAutorizaSalidaSinHuella As String = ""
        Public Property TipoSalidaPor As Short = -1
        Public Property TipoIngresoPor As Short = -1
        Public Property NumeroRecaptura As Short = 0

        Public ReadOnly Property TipoIngresoPorNombreReadonly As String
            Get
                Dim value As String = ""

                Select Case Me.TipoIngresoPor

                    Case Type.Enumeracion.Visita.Movimiento.IngresoPor.Ninguno
                        'value = "Sin Huellas"
                        value = "DI"

                    Case Type.Enumeracion.Visita.Movimiento.IngresoPor.CapturaHuella
                        'value = "Captura Inicial de huellas"
                        value = "CI"

                    Case Type.Enumeracion.Visita.Movimiento.IngresoPor.VerificacionHuella
                        'value = "Verificacion de huellas"
                        value = "VH"

                    Case Type.Enumeracion.Visita.Movimiento.IngresoPor.HuellaObs
                        'value = "Huella observada"
                        value = "HO"

                    Case Type.Enumeracion.Visita.Movimiento.IngresoPor.Recaptura

                        value = "R" & NumeroRecaptura

                    Case Type.Enumeracion.Visita.Movimiento.IngresoPor.VerificacionHuellaRecaptura

                        value = "VH - R" & NumeroRecaptura

                    Case Type.Enumeracion.Visita.Movimiento.IngresoPor.HuellaObsRecaptura

                        value = "HO - R" & NumeroRecaptura

                    Case Else
                        'value = "No determinado"
                        value = "ND"
                End Select

                Return value
            End Get
        End Property
        Public ReadOnly Property TipoSalidaPorNombreReadonly As String
            Get
                Dim value As String = ""

                Select Case Me.TipoSalidaPor

                    Case Type.Enumeracion.Visita.Movimiento.SalidaPor.DNI

                        If Me.UsuarioAutorizaSalida.Length > 3 Then
                            'value = "Numero Documento"
                            value = "DI"
                        Else
                            value = ""
                        End If

                    Case Type.Enumeracion.Visita.Movimiento.SalidaPor.Huella
                        'value = "verificacion de Huella"
                        value = "VH"

                    Case Type.Enumeracion.Visita.Movimiento.SalidaPor.Masivo
                        'value = "Masivo"
                        value = "MA"

                    Case Else
                        'value = "No determinado"
                        value = "ND"
                End Select

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Interno"

        Public Property TipoInterno As Integer = 1 'interno inpe
        Public Property InternoID As Integer = -1
        Public Property IDInternoPJ As Integer = -1

        Public Property InternoCodigoPadre As Integer = -1
        Public Property InternoCodigo() As String = ""
        Public Property InternoNumeroDocumento() As String = ""
        Public Property InternoApePaterno() As String = ""
        Public Property InternoApeMaterno() As String = ""
        Public Property InternoNombres() As String = ""
        Public Property InternoApellidos() As String = ""
        Public ReadOnly Property InternoApellidosReadonly() As String
            Get
                Dim strValue As String = ""
                strValue = Me.InternoApePaterno & " " & Me.InternoApeMaterno
                Return strValue.ToUpper
            End Get
        End Property
        Public ReadOnly Property InternoApellidosyNombresReadonly() As String
            Get
                Dim strValue As String = ""

                If Me.InternoID > 0 Or Me.IDInternoPJ > 0 Then
                    strValue = Me.InternoApePaterno & " " & Me.InternoApeMaterno & ", " & Me.InternoNombres
                End If

                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
        Public Property InternoApellidosyNombres() As String = ""
        Public Property InternoSitJuridica() As String = ""
        Public Property InternoEstado() As Short = -1

        Public ReadOnly Property InternoEstadoNom() As String
            Get
                Dim strValue As String = ""
                Select Case Me.InternoEstado
                    Case 0
                        strValue = "Inactivo"
                    Case 1
                        strValue = "Activo"
                End Select

                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get

        End Property
        Public Property InternoAutorizado() As Boolean = False
#End Region
#Region "Propiedades_Visita"

        Public Property VisitanteApePaterno() As String = ""
        Public Property VisitanteApeMaterno() As String = ""
        Public Property VisitanteNombres() As String = ""
        Public ReadOnly Property VisitanteApellidosyNombresReadonly() As String
            Get
                Dim strValue As String = ""

                If Me.VisitaID > 0 Then
                    strValue = Me.VisitanteApePaterno & " " & Me.VisitanteApeMaterno & ", " & Me.VisitanteNombres
                End If

                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
        Public Property VisitanteApellidosyNombres() As String = ""
        Public Property IDFotoVisitante As Integer = -1
        Public Property VisitanteFotoName() As String = ""
        Public Property VisitanteSexoID() As Short = -1

        Public ReadOnly Property VisitanteSexoNombre() As String
            Get

                Dim strValue As String = ""
                Select Case Me.VisitanteSexoID
                    Case 1
                        strValue = "Masculino"
                    Case 2
                        strValue = "Femenino"
                End Select
                Return strValue
            End Get
        End Property
        Public Property VisitanteIDTipoDocumento As Short = -1
        Public Property VisitanteTipoDocumento() As String = ""
        Public Property VisitanteNumeroDocumento() As String = ""

        Public ReadOnly Property VisitanteTipoDocyNumeroDoc() As String
            Get
                Dim value As String = ""
                value = Me.VisitanteTipoDocumento & " - " & Me.VisitanteNumeroDocumento
                Return value
            End Get
        End Property
        Public Property VisitanteFechaNacimiento() As Long = 0

        Public ReadOnly Property VisitanteEdadFecNac() As Short
            Get
                Dim value As Integer = 0

                If Legolas.LEntity.Config.FechaHoy < 1 Then
                    Return value
                End If

                If VisitanteFechaNacimiento < 1 Then
                    Return value
                End If

                value = Legolas.Components.FechaHora.FechaCalcularAnio(Me.VisitanteFechaNacimiento, _
                                                                       Legolas.LEntity.Config.FechaHoy, True)

                Return value
            End Get

        End Property
        Public ReadOnly Property VisitanteEdadString() As String
            Get
                Dim value As String = ""

                If Me.VisitanteFechaNacimiento > 0 Then
                    value = Me.VisitanteEdadFecNac
                End If

                Return value
            End Get

        End Property

        Public Property VisitanteDatosConcatenados As String = ""
        Public Property VisitanteValidadoReniec As Short = 0
        Public ReadOnly Property VisitanteValidadoReniecNombreReadonly As String
            Get
                Dim value As String = ""

                Select Case Me.VisitanteValidadoReniec
                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar
                        value = "Sin validar"
                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado, Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                        value = "Validado"
                    Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.Diferencias
                        value = "Diferencias"
                    Case Else
                        value = "No Determinado"
                End Select

                Return value

            End Get
        End Property

#End Region
#Region "Propiedades_Sancion"
        Public Property VisitaSancion() As Boolean = False

        Public ReadOnly Property VisitaSancionStr() As String
            Get
                Dim _str As String = ""
                If VisitaSancion = True Then
                    _str = "Sancionado"
                End If
                Return _str
            End Get
        End Property
#End Region
#Region "Filtro"
        Public Property FechaInicio As Long = 0
        Public Property FechaFin As Long = 0
#End Region
#Region "Iconos"
        Public ReadOnly Property IconoMenor() As System.Drawing.Image
            Get

                Dim Value As System.Drawing.Image = Nothing
                If Me.MenoresCantidad > 0 Then
                    Value = Entity.My.Resources.boy
                Else
                    Value = Entity.My.Resources.check_box_black
                End If

                Return Value

            End Get
        End Property

#End Region
    End Class
#Region "MovimientoCol"
    Public Class MovimientoCol
        Inherits System.Collections.CollectionBase
        Dim asa As List(Of String)
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, sortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As Movimiento) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Movimiento(ByVal Index As Integer) As Movimiento
            Get
                Return CType(MyBase.List(Index), Movimiento)
            End Get
        End Property
        Public Function CloneCol() As Movimiento
            Return MyBase.MemberwiseClone
        End Function
        Public Sub Remove(ByVal index As Integer)
            If index <= Count - 1 OrElse index >= 0 Then
                Me.List.RemoveAt(index)
                'Me.List.Remove(index)
            End If
        End Sub
        Public Function Find_Interno(ByVal objEnCol As MovimientoCol, ByVal InternoID As Integer) As Boolean

            Dim blnValue As Boolean = False

            For Each objEnt As Movimiento In objEnCol

                If objEnt.InternoID = InternoID Then
                    blnValue = True
                    Exit For
                End If
            Next

            Return blnValue
        End Function
        Public Function Find_Visitante(ByVal objEnCol As MovimientoCol, ByVal VisitanteID As Integer) As Boolean

            Dim blnValue As Boolean = False

            For Each objEnt As Movimiento In objEnCol

                If objEnt.VisitaID = VisitanteID Then
                    blnValue = True
                    Exit For
                End If
            Next

            Return blnValue
        End Function

        '    Public Function Buscar(ByVal valor As String) As Object
        '        Dim result As Object
        '        Dim t As System.Type = GetType(Movimiento)
        '        Try
        '            result = t.InvokeMember(valor, BindingFlags.GetField Or BindingFlags.GetProperty, Nothing, Me, New Object() {})
        '        Catch ex As Exception
        '            result = ""
        '        End Try
        '        Return result

        '    End Function
    End Class
    'Public Class MovimientoCol2
    '    Inherits System.Collections.Generic.List(Of Movimiento)
    'End Class
#End Region

End Namespace