
Namespace General
#Region "Ubigeo"
    Public Class Ubigeo
        Private _intCodigo As Integer
        Private _intPais As Integer
        Private _intDepartamento As Integer
        Private _intProvincia As Integer
        Private _intDistrito As Integer
        Private _strNombre As String

#Region "Propiedades"
        Public Property Codigo() As Integer
            Get
                Return _intCodigo
            End Get
            Set(ByVal value As Integer)
                _intCodigo = value
            End Set
        End Property
        Public Property Pais() As Integer
            Get
                Return _intPais
            End Get
            Set(ByVal value As Integer)
                _intPais = value
            End Set
        End Property
        Public Property Departamento() As Integer
            Get
                Return _intDepartamento
            End Get
            Set(ByVal value As Integer)
                _intDepartamento = value
            End Set
        End Property
        Public Property Provincia() As Integer
            Get
                Return _intProvincia
            End Get
            Set(ByVal value As Integer)
                _intProvincia = value
            End Set
        End Property
        Public Property Distrito() As Integer
            Get
                Return _intDistrito
            End Get
            Set(ByVal value As Integer)
                _intDistrito = value
            End Set
        End Property
        Public Property Nombre() As String
            Get
                Return StrConv(_strNombre, VbStrConv.ProperCase)
            End Get
            Set(ByVal value As String)
                _strNombre = StrConv(value, VbStrConv.ProperCase)
            End Set
        End Property
#End Region
    End Class
#End Region

#Region "UbigeoCol"
    Public Class UbigeoCol
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

        Public Function Add(ByVal obj As Ubigeo) As Integer

            Return MyBase.List.Add(obj)
        End Function

        Public ReadOnly Property Ubigeo(ByVal Index As Integer) As Ubigeo
            Get
                Return CType(MyBase.List(Index), Ubigeo)
            End Get
        End Property

    End Class
#End Region

End Namespace