Namespace Reporte.FichaIdentificacion
    Public Class Rasgos
#Region "Propiedades"
        Private strRaza As String = ""
        Private decTalla As Decimal = 0
        Private decPeso As Decimal = 0
        Private strFormaCara As String = ""
        Private strMenton As String = ""
        Private strFrente As String = ""
        Private strColorCabello As String = ""
        Private strFormaCabello As String = ""
        Private strFormaOjos As String = ""
        Private strIris As String = ""
        Private strCeja As String = ""
        Private strBoca As String = ""
        Private strLabios As String = ""
        Private strTipoLabios As String = ""
        Private strTipoNariz As String = ""
        Private strFormaNariz As String = ""
        Private strLineaInsercion As String = ""
        Private strOreja As String = ""
        Private strTronco As String = ""
        Private strComplexion As String = ""
        Private strAnomaliaOjos As String = ""
        Private strCalvicie As String = ""
        Public Property Raza() As String
            Get
                Return strRaza
            End Get
            Set(ByVal value As String)
                strRaza = value
            End Set
        End Property
        Public Property Talla() As Decimal
            Get
                Return decTalla
            End Get
            Set(ByVal value As Decimal)
                decTalla = value
            End Set
        End Property
        Public Property Peso() As Decimal
            Get
                Return decPeso
            End Get
            Set(ByVal value As Decimal)
                decPeso = value
            End Set
        End Property
        Public Property FormaCara() As String
            Get
                Return strFormaCara
            End Get
            Set(ByVal value As String)
                strFormaCara = value
            End Set
        End Property
        Public Property Menton() As String
            Get
                Return strMenton
            End Get
            Set(ByVal value As String)
                strMenton = value
            End Set
        End Property
        Public Property Frente() As String
            Get
                Return strFrente
            End Get
            Set(ByVal value As String)
                strFrente = value
            End Set
        End Property
        Public Property ColorCabello() As String
            Get
                Return strColorCabello
            End Get
            Set(ByVal value As String)
                strColorCabello = value
            End Set
        End Property
        Public Property FormaCabello() As String
            Get
                Return strFormaCabello
            End Get
            Set(ByVal value As String)
                strFormaCabello = value
            End Set
        End Property
        Public Property FormaOjos() As String
            Get
                Return strFormaOjos
            End Get
            Set(ByVal value As String)
                strFormaOjos = value
            End Set
        End Property
        Public Property Iris() As String
            Get
                Return strIris
            End Get
            Set(ByVal value As String)
                strIris = value
            End Set
        End Property
        Public Property Ceja() As String
            Get
                Return strCeja
            End Get
            Set(ByVal value As String)
                strCeja = value
            End Set
        End Property
        Public Property Boca() As String
            Get
                Return strBoca
            End Get
            Set(ByVal value As String)
                strBoca = value
            End Set
        End Property
        Public Property Labios() As String
            Get
                Return strLabios
            End Get
            Set(ByVal value As String)
                strLabios = value
            End Set
        End Property
        Public Property TipoLabios() As String
            Get
                Return strTipoLabios
            End Get
            Set(ByVal value As String)
                strTipoLabios = value
            End Set
        End Property
        Public Property TipoNariz() As String
            Get
                Return strTipoNariz
            End Get
            Set(ByVal value As String)
                strTipoNariz = value
            End Set
        End Property
        Public Property FormaNariz() As String
            Get
                Return strFormaNariz
            End Get
            Set(ByVal value As String)
                strFormaNariz = value
            End Set
        End Property
        Public Property LineaInsercion() As String
            Get
                Return strLineaInsercion
            End Get
            Set(ByVal value As String)
                strLineaInsercion = value
            End Set
        End Property
        Public Property Oreja() As String
            Get
                Return strOreja
            End Get
            Set(ByVal value As String)
                strOreja = value
            End Set
        End Property
        Public Property Tronco() As String
            Get
                Return strTronco
            End Get
            Set(ByVal value As String)
                strTronco = value
            End Set
        End Property
        Public Property Complexion() As String
            Get
                Return strComplexion
            End Get
            Set(ByVal value As String)
                strComplexion = value
            End Set
        End Property
        Public Property AnomaliaOjos() As String
            Get
                Return strAnomaliaOjos
            End Get
            Set(ByVal value As String)
                strAnomaliaOjos = value
            End Set
        End Property
        Public Property Calvicie() As String
            Get
                Return strCalvicie
            End Get
            Set(ByVal value As String)
                strCalvicie = value
            End Set
        End Property
#End Region
    End Class
#Region "RasgosCol"
    Public Class RasgosCol
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
        Public Function Add(ByVal obj As Rasgos) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Rasgos(ByVal Index As Integer) As Rasgos
            Get
                Return CType(MyBase.List(Index), Rasgos)
            End Get
        End Property
    End Class
#End Region
End Namespace