Namespace Reporte.Estadistica
    Public Class Reporte02
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
#Region "Interno"
        Private strApellidoPaterno As String = ""
        Private strApellidoMaterno As String = ""
        Private strNombres As String = ""
        Private strNombresyApellidos As String = ""
        Private lngFechaNacimiento As Long = 0
        Private strSexo As String = ""
        Private strNacionalidad As String = ""
        Private strDelitoEspecificoNombre As String = ""
        Private strSituacionJuridicaNombre As String = ""
        Private lngFechaIngreso As Long = 0
        Private intSentenciaAnio As Integer = 0
        Private intSentenciaMes As Integer = 0
        Private intSentenciaDia As Integer = 0
        Private strAutoridadJudicialNombre As String = ""
        Private strNumeroExpediente As String = ""
        Private strSalaJudicialNombre As String = ""
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
        Public Property Nacionalidad() As String
            Get
                Return strNacionalidad
            End Get
            Set(ByVal value As String)
                strNacionalidad = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property DelitoEspecificoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDelitoEspecificoNombre)
            End Get
            Set(ByVal value As String)
                strDelitoEspecificoNombre = value
            End Set
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
        Public Property AutoridadJudicialNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strAutoridadJudicialNombre)
            End Get
            Set(ByVal value As String)
                strAutoridadJudicialNombre = value
            End Set
        End Property
        Public Property SalaJudicialNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSalaJudicialNombre)
            End Get
            Set(ByVal value As String)
                strSalaJudicialNombre = value
            End Set
        End Property
        Public ReadOnly Property SalaJudicialyAutoridadJudicalNombre() As String
            Get
                Dim value As String = ""

                value = Me.SalaJudicialNombre & "/" & Me.AutoridadJudicialNombre

                Return value

            End Get
        End Property
        Public Property NumeroExpediente() As String
            Get
                Return strNumeroExpediente
            End Get
            Set(ByVal value As String)
                strNumeroExpediente = value
            End Set
        End Property
#End Region
    End Class
#Region "Reporte02Col"
    Public Class Reporte02Col
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
        Public Function Add(ByVal obj As Reporte02) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Reporte02(ByVal Index As Integer) As Reporte02
            Get
                Return CType(MyBase.List(Index), Reporte02)
            End Get
        End Property
    End Class
#End Region
End Namespace
