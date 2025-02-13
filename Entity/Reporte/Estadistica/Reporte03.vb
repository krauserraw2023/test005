Namespace Reporte.Estadistica
    Public Class Reporte03
#Region "Penal"
        Private strPenalNombre As String = ""
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
#End Region
#Region "Familiar"
        Private strFamiliarApellidoPaterno As String = ""
        Private strFamiliarApellidoMaterno As String = ""
        Private strFamiliarNombres As String = ""
        Private lngFechaNacimiento As Long = 0
        Private strSexo As String = ""
        Public Property FamiliarApellidoPaterno() As String
            Get
                Return strFamiliarApellidoPaterno
            End Get
            Set(ByVal value As String)
                strFamiliarApellidoPaterno = value
            End Set
        End Property
        Public Property FamiliarApellidoMaterno() As String
            Get
                Return strFamiliarApellidoMaterno
            End Get
            Set(ByVal value As String)
                strFamiliarApellidoMaterno = value
            End Set
        End Property
        Public Property FamiliarNombres() As String
            Get
                Return strFamiliarNombres
            End Get
            Set(ByVal value As String)
                strFamiliarNombres = value
            End Set
        End Property
        Public ReadOnly Property FamiliarApellidosyNombres() As String
            Get
                Dim strValue As String = ""
                strValue = Me.FamiliarApellidoPaterno & " " & Me.FamiliarApellidoMaterno & ", " & Me.FamiliarNombres
                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
        Public Property FechaNacimiento() As Long
            Get
                Return lngFechaNacimiento
            End Get
            Set(ByVal value As Long)
                lngFechaNacimiento = value
            End Set
        End Property
        Public ReadOnly Property FechaNacimientoString() As String
            Get
                Dim strValue As String = ""
                strValue = Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)
                Return strValue
            End Get
        End Property
        Public Property Sexo() As String
            Get
                Return strSexo
            End Get
            Set(ByVal value As String)
                strSexo = value
            End Set
        End Property
#End Region
#Region "Interno"
        Private strApellidoPaterno As String = ""
        Private strApellidoMaterno As String = ""
        Private strNombres As String = ""
        Private strNombresyApellidos As String = ""
        Private strSituacionJuridicaNombre As String = ""
        Private lngFechaIngreso As Long = 0
        Private intSentenciaAnio As Integer = 0
        Private intSentenciaMes As Integer = 0
        Private intSentenciaDia As Integer = 0
        Public Property ApellidoPaterno() As String
            Get
                Return strApellidoPaterno
            End Get
            Set(ByVal value As String)
                strApellidoPaterno = value
            End Set
        End Property
        Public Property ApellidoMaterno() As String
            Get
                Return strApellidoMaterno
            End Get
            Set(ByVal value As String)
                strApellidoMaterno = value
            End Set
        End Property
        Public Property Nombres() As String
            Get
                Return strNombres
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Public ReadOnly Property NombresyApellidos() As String
            Get
                Dim strValue As String = ""
                strValue = Me.Nombres & " " & Me.ApellidoPaterno & " " & Me.ApellidoMaterno
                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
        Public Property SituacionJuridicaNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSituacionJuridicaNombre)
            End Get
            Set(ByVal value As String)
                strSituacionJuridicaNombre = value
            End Set
        End Property
        Public Property FechaIngreso() As Long
            Get
                Return lngFechaIngreso
            End Get
            Set(ByVal value As Long)
                lngFechaIngreso = value
            End Set
        End Property
        Public ReadOnly Property FechaIngresoString() As String
            Get
                Dim strValue As String = ""
                strValue = Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
                Return strValue
            End Get
        End Property
        Public Property SentenciaAnio() As Integer
            Get
                Return intSentenciaAnio
            End Get
            Set(ByVal value As Integer)
                intSentenciaAnio = value
            End Set
        End Property
        Public Property SentenciaMes() As Integer
            Get
                Return intSentenciaMes
            End Get
            Set(ByVal value As Integer)
                intSentenciaMes = value
            End Set
        End Property
        Public Property SentenciaDia() As Integer
            Get
                Return intSentenciaDia
            End Get
            Set(ByVal value As Integer)
                intSentenciaDia = value
            End Set
        End Property
#End Region
    End Class
#Region "Reporte03Col"
    Public Class Reporte03Col
        Inherits System.Collections.CollectionBase
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
        Public Function Add(ByVal obj As Reporte03) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Reporte03(ByVal Index As Integer) As Reporte03
            Get
                Return CType(MyBase.List(Index), Reporte03)
            End Get
        End Property
    End Class
#End Region
End Namespace
