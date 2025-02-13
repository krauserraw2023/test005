Namespace Visita
    Public Class Calendario
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intTipo As Integer = -1
        Private strTipo As String = ""
        Private lngFechaDesde As Long = 0
        Private intFechaDesdeDia As Integer = -1
        Private intFechaDesdeMes As Integer = -1
        Private intFechaDesdeAnio As Integer = -1
        Private lngFechaHasta As Long = 0
        Private intFechaHastaDia As Integer = -1
        Private intFechaHastaMes As Integer = -1
        Private intFechaHastaAnio As Integer = -1
        Private intHoraDesde As Integer = -1
        Private intHoraHasta As Integer = -1
        Private intSexo As Integer = -1
        Private blnMenores As Boolean = False
        Private blnLunes As Boolean = False
        Private blnMartes As Boolean = False
        Private blnMiercoles As Boolean = False
        Private blnJueves As Boolean = False
        Private blnViernes As Boolean = False
        Private blnSabado As Boolean = False
        Private blnDomingo As Boolean = False

        Private intPenal As Integer = -1
        Private intRegion As Integer = -1

        Private intEstado As Integer = -1

        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property Tipo() As Integer
            Get
                Return intTipo
            End Get
            Set(ByVal value As Integer)
                intTipo = value
            End Set
        End Property

        Public Property TipoStr() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipo)
            End Get
            Set(ByVal value As String)
                strTipo = value
            End Set
        End Property
        Public Property FechaDesde() As Long
            Get
                Return lngFechaDesde
            End Get
            Set(ByVal value As Long)
                lngFechaDesde = value
            End Set
        End Property
        Public ReadOnly Property FechaDesdeStr() As String
            Get
                Dim Str As String = ""

                If FechaDesde > 0 Then
                    Str = System.DateTime.FromFileTime(FechaDesde).ToShortDateString
                End If

                Return Str
            End Get
        End Property

        Public Property FechaDesdeDia() As Integer
            Get
                Return intFechaDesdeDia
            End Get
            Set(ByVal value As Integer)
                intFechaDesdeDia = value
            End Set
        End Property
        Public Property FechaDesdeMes() As Integer
            Get
                Return intFechaDesdeMes
            End Get
            Set(ByVal value As Integer)
                intFechaDesdeMes = value
            End Set
        End Property
        Public Property FechaDesdeAnio() As Integer
            Get
                Return intFechaDesdeAnio
            End Get
            Set(ByVal value As Integer)
                intFechaDesdeAnio = value
            End Set
        End Property
        Public Property FechaHasta() As Long
            Get
                Return lngFechaHasta
            End Get
            Set(ByVal value As Long)
                lngFechaHasta = value
            End Set
        End Property
        Public ReadOnly Property FechaHastaStr() As String
            Get
                Dim Str As String = ""

                If FechaDesde > 0 Then
                    Str = System.DateTime.FromFileTime(FechaHasta).ToShortDateString
                End If

                Return Str
            End Get
        End Property
        Public Property FechaHastaDia() As Integer
            Get
                Return intFechaHastaDia
            End Get
            Set(ByVal value As Integer)
                intFechaHastaDia = value
            End Set
        End Property
        Public Property FechaHastaMes() As Integer
            Get
                Return intFechaHastaMes
            End Get
            Set(ByVal value As Integer)
                intFechaHastaMes = value
            End Set
        End Property
        Public Property FechaHastaAnio() As Integer
            Get
                Return intFechaHastaAnio
            End Get
            Set(ByVal value As Integer)
                intFechaHastaAnio = value
            End Set
        End Property
        Public Property HoraDesde() As Integer
            Get
                Return intHoraDesde
            End Get
            Set(ByVal value As Integer)
                intHoraDesde = value
            End Set
        End Property

        Public ReadOnly Property HoraDesdeStr() As String
            Get
                Dim _hora As Integer = 0
                Dim _minuto As Integer = 0

                _hora = Math.DivRem(HoraDesde, 60, _minuto)

                Return Legolas.Components.Cadena.Format(_hora.ToString, "00") + _
                ":" + Legolas.Components.Cadena.Format(_minuto.ToString, "00")

            End Get

        End Property
        Public Property HoraHasta() As Integer
            Get
                Return intHoraHasta
            End Get
            Set(ByVal value As Integer)
                intHoraHasta = value
            End Set
        End Property

        Public ReadOnly Property HoraHastaStr() As String
            Get
                Dim _hora As Integer = 0
                Dim _minuto As Integer = 0

                _hora = Math.DivRem(HoraHasta, 60, _minuto)

                Return Legolas.Components.Cadena.Format(_hora.ToString, "00") + _
                ":" + Legolas.Components.Cadena.Format(_minuto.ToString, "00")

            End Get

        End Property

        Public Property Sexo() As Integer
            Get
                Return intSexo
            End Get
            Set(ByVal value As Integer)
                intSexo = value
            End Set
        End Property

        Public ReadOnly Property SexoStr() As String
            Get
                Dim _str As String = ""

                Select Case Sexo
                    Case 1
                        _str = "Hombres"
                    Case 2
                        _str = "Mujeres"
                    Case 3
                        _str = "Mixto"
                End Select

                Return _str
            End Get

        End Property

        Public Property Menores() As Boolean
            Get
                Return blnMenores
            End Get
            Set(ByVal value As Boolean)
                blnMenores = value
            End Set
        End Property
        Public Property Lunes() As Boolean
            Get
                Return blnLunes
            End Get
            Set(ByVal value As Boolean)
                blnLunes = value
            End Set
        End Property
        Public Property Martes() As Boolean
            Get
                Return blnMartes
            End Get
            Set(ByVal value As Boolean)
                blnMartes = value
            End Set
        End Property
        Public Property Miercoles() As Boolean
            Get
                Return blnMiercoles
            End Get
            Set(ByVal value As Boolean)
                blnMiercoles = value
            End Set
        End Property
        Public Property Jueves() As Boolean
            Get
                Return blnJueves
            End Get
            Set(ByVal value As Boolean)
                blnJueves = value
            End Set
        End Property
        Public Property Viernes() As Boolean
            Get
                Return blnViernes
            End Get
            Set(ByVal value As Boolean)
                blnViernes = value
            End Set
        End Property
        Public Property Sabado() As Boolean
            Get
                Return blnSabado
            End Get
            Set(ByVal value As Boolean)
                blnSabado = value
            End Set
        End Property
        Public Property Domingo() As Boolean
            Get
                Return blnDomingo
            End Get
            Set(ByVal value As Boolean)
                blnDomingo = value
            End Set
        End Property
        Public Property Region() As Integer
            Get
                Return intRegion
            End Get
            Set(ByVal value As Integer)
                intRegion = value
            End Set
        End Property
        Public Property Penal() As Integer
            Get
                Return intPenal
            End Get
            Set(ByVal value As Integer)
                intPenal = value
            End Set
        End Property
        Public Property Estado() As Integer
            Get
                Return intEstado
            End Get
            Set(ByVal value As Integer)
                intEstado = value
            End Set
        End Property



#End Region
    End Class
#Region "CalendarioCol"
    Public Class CalendarioCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, SortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As Calendario) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Calendario(ByVal Index As Integer) As Calendario
            Get
                Return CType(MyBase.List(Index), Calendario)
            End Get
        End Property
        Public Function CloneCol() As Calendario
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace