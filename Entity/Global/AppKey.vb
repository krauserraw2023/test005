Namespace General
    Public Class AppKey
        Inherits Auditoria.Transaccion
        Private intCodigo As Integer = -1
        Private intModulo As Integer = -1
        Private strKey As String = ""
        Private strValor As String = ""
        Private lngValorIng As Long = 0
        Private strDescripcion As String = ""
#Region "Propiedades"
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property Modulo() As Integer
            Get
                Return intModulo
            End Get
            Set(ByVal value As Integer)
                intModulo = value
            End Set
        End Property
        Public Property Key() As String
            Get
                Return strKey
            End Get
            Set(ByVal value As String)
                strKey = value
            End Set
        End Property
        Public Property Valor() As String
            Get
                Return strValor
            End Get
            Set(ByVal value As String)
                strValor = value
            End Set
        End Property
        Public Property ValorIng() As Long
            Get
                Return lngValorIng
            End Get
            Set(ByVal value As Long)
                lngValorIng = value
            End Set
        End Property
        Public Property Descripcion() As String
            Get
                Return strDescripcion
            End Get
            Set(ByVal value As String)
                strDescripcion = value
            End Set
        End Property
#End Region
    End Class
#Region "AppKeyCol"
    Public Class AppKeyCol
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
        Public Function Add(ByVal obj As AppKey) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property AppKey(ByVal Index As Integer) As AppKey
            Get
                Return CType(MyBase.List(Index), AppKey)
            End Get
        End Property

        Public Function AppKeyStr(ByVal vKey As String) As AppKey
            Dim _key2 As New AppKey
            For Each _key As AppKey In Me
                If _key.Key = vKey Then
                    _key2 = _key
                    Exit For
                End If
            Next

            Return _key2
        End Function




    End Class
#End Region
End Namespace


