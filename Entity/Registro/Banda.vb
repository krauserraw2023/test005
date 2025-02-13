Namespace Registro
    Public Class Banda
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intBandaTipo As Integer = -1
        Private strBandaTipoNombre As String = ""
        Private strBandaNombre As String = ""
        Private strBandaDescripcion As String = ""
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property BandaTipoID() As Integer
            Get
                Return intBandaTipo
            End Get
            Set(ByVal value As Integer)
                intBandaTipo = value
            End Set
        End Property
        Public Property BandaTipoNombre As String
            Get
                Return UCase(strBandaTipoNombre)
            End Get
            Set(ByVal value As String)
                strBandaTipoNombre = value
            End Set
        End Property

        Public Property BandaNombre() As String
            Get
                Return UCase(strBandaNombre)
            End Get
            Set(ByVal value As String)
                strBandaNombre = value
            End Set
        End Property
        Public Property BandaDescripcion() As String
            Get
                Return UCase(strBandaDescripcion)
            End Get
            Set(ByVal value As String)
                strBandaDescripcion = value
            End Set
        End Property
#End Region
    End Class
#Region "BandaCol"
    Public Class BandaCol
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
        Public Function Add(ByVal obj As Banda) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Bandas(ByVal Index As Integer) As Banda
            Get
                Return CType(MyBase.List(Index), Banda)
            End Get
        End Property
    End Class
#End Region
End Namespace
