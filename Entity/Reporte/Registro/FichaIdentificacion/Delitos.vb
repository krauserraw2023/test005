Namespace Reporte.FichaIdentificacion
    Public Class Delitos
#Region "Propiedades_Expediente"
        Private lngInternoExpedienteID As Long = 0
        Private lngFechaMandato As Long = 0
        Private strNumeroExpediente As String = ""
        Private strDistritoJudicial As String = ""
        Private strAutoridadJudicial As String = ""
        Private strSituacionJuridica As String = ""        
        Public Property InternoExpedienteID() As Long
            Get
                Return lngInternoExpedienteID
            End Get
            Set(ByVal value As Long)
                lngInternoExpedienteID = value
            End Set
        End Property
        Public Property FechaMandato() As Long
            Get
                Return lngFechaMandato
            End Get
            Set(ByVal value As Long)
                lngFechaMandato = value
            End Set
        End Property
        Public ReadOnly Property FechaMandatoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaMandato)
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
        Public Property DistritoJudicial() As String
            Get
                Return strDistritoJudicial
            End Get
            Set(ByVal value As String)
                strDistritoJudicial = value
            End Set
        End Property
        Public Property AutoridadJudicial() As String
            Get
                Return strAutoridadJudicial
            End Get
            Set(ByVal value As String)
                strAutoridadJudicial = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property Estado() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSituacionJuridica)
            End Get
            Set(ByVal value As String)
                strSituacionJuridica = value
            End Set
        End Property
#End Region
#Region "Propiedades_Delito"
        Private strNombre As String = ""
        Private strMinimo As String = ""
        Private strMaximo As String = ""
        Public Property Nombre() As String
            Get
                Return strNombre
            End Get
            Set(ByVal value As String)
                strNombre = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property Minimo() As String
            Get
                Return strMinimo
            End Get
            Set(ByVal value As String)
                strMinimo = value
            End Set
        End Property
        Public Property Maximo() As String
            Get
                Return strMaximo
            End Get
            Set(ByVal value As String)
                strMaximo = value
            End Set
        End Property
#End Region
    End Class
#Region "DelitosCol"
    Public Class DelitosCol
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
        Public Function Add(ByVal obj As Delitos) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Delitos(ByVal Index As Integer) As Delitos
            Get
                Return CType(MyBase.List(Index), Delitos)
            End Get
        End Property
    End Class
#End Region
End Namespace