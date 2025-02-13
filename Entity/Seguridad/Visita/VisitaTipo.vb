Namespace Visita
    Public Class Tipo
        Private intTipoId As Integer
        Private strTipoNombre As String
        Private intEstado As Integer
        'Private intCalendario As Integer
        'Private intInternoSeleccion As Integer

        Public Property Codigo() As Integer
            Get
                Return intTipoId
            End Get
            Set(ByVal value As Integer)
                intTipoId = value
            End Set
        End Property

        Public Property Nombre() As String
            Get
                Return strTipoNombre
            End Get
            Set(ByVal value As String)
                strTipoNombre = value
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

        'Public Property RequiereCalendario() As Integer
        '    Get
        '        Return intCalendario
        '    End Get
        '    Set(ByVal value As Integer)
        '        intCalendario = value
        '    End Set
        'End Property

        'Public Property RequiereInterno() As Integer
        '    Get
        '        Return intInternoSeleccion
        '    End Get
        '    Set(ByVal value As Integer)
        '        intInternoSeleccion = value
        '    End Set
        'End Property


    End Class

#Region "Tipos"
    Public Class Tipos
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
        Public Function Add(ByVal obj As Tipo) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property parametrica(ByVal Index As Integer) As Tipo
            Get
                Return CType(MyBase.List(Index), Tipo)
            End Get
        End Property
    End Class
#End Region


End Namespace
