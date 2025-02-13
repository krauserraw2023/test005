Namespace Reporte.Estadistica.F1
    Public Class Cuadro011
#Region "Propiedades"
        Private intIngreso1 As Integer = 0
        Private intIngreso2 As Integer = 0
        Private intIngreso3 As Integer = 0
        Private intIngreso4 As Integer = 0
        Private intIngreso5 As Integer = 0
        Private intIngreso6 As Integer = 0
        Private intIngreso7 As Integer = 0
        Private intIngreso8 As Integer = 0
        Private intIngreso9 As Integer = 0
        Private intIngreso10 As Integer = 0
        Private intIngreso11 As Integer = 0
        Private intIngreso12 As Integer = 0
        Private intIngreso13 As Integer = 0
        Private intIngreso14 As Integer = 0
        Private intIngreso15 As Integer = 0
        Private intIngreso16 As Integer = 0
        Private intIngreso As Integer = 0
        Private strNombre As String = ""
        Public Property Ingreso() As Integer
            Get
                Return intIngreso
            End Get
            Set(ByVal value As Integer)
                intIngreso = value
            End Set
        End Property
        Public Property Nombre() As String
            Get
                Return strNombre
            End Get
            Set(ByVal value As String)
                strNombre = value
            End Set
        End Property
        Public Property Ingreso1() As Integer
            Get
                Return intIngreso1
            End Get
            Set(ByVal value As Integer)
                intIngreso1 = value
            End Set
        End Property
        Public Property Ingreso2() As Integer
            Get
                Return intIngreso2
            End Get
            Set(ByVal value As Integer)
                intIngreso2 = value
            End Set
        End Property
        Public Property Ingreso3() As Integer
            Get
                Return intIngreso3
            End Get
            Set(ByVal value As Integer)
                intIngreso3 = value
            End Set
        End Property
        Public Property Ingreso4() As Integer
            Get
                Return intIngreso4
            End Get
            Set(ByVal value As Integer)
                intIngreso4 = value
            End Set
        End Property
        Public Property Ingreso5() As Integer
            Get
                Return intIngreso5
            End Get
            Set(ByVal value As Integer)
                intIngreso5 = value
            End Set
        End Property
        Public Property Ingreso6() As Integer
            Get
                Return intIngreso6
            End Get
            Set(ByVal value As Integer)
                intIngreso6 = value
            End Set
        End Property
        Public Property Ingreso7() As Integer
            Get
                Return intIngreso7
            End Get
            Set(ByVal value As Integer)
                intIngreso7 = value
            End Set
        End Property
        Public Property Ingreso8() As Integer
            Get
                Return intIngreso8
            End Get
            Set(ByVal value As Integer)
                intIngreso8 = value
            End Set
        End Property
        Public Property Ingreso9() As Integer
            Get
                Return intIngreso9
            End Get
            Set(ByVal value As Integer)
                intIngreso9 = value
            End Set
        End Property
        Public Property Ingreso10() As Integer
            Get
                Return intIngreso10
            End Get
            Set(ByVal value As Integer)
                intIngreso10 = value
            End Set
        End Property
        Public Property Ingreso11() As Integer
            Get
                Return intIngreso11
            End Get
            Set(ByVal value As Integer)
                intIngreso11 = value
            End Set
        End Property
        Public Property Ingreso12() As Integer
            Get
                Return intIngreso12
            End Get
            Set(ByVal value As Integer)
                intIngreso12 = value
            End Set
        End Property
        Public Property Ingreso13() As Integer
            Get
                Return intIngreso13
            End Get
            Set(ByVal value As Integer)
                intIngreso13 = value
            End Set
        End Property
        Public Property Ingreso14() As Integer
            Get
                Return intIngreso14
            End Get
            Set(ByVal value As Integer)
                intIngreso14 = value
            End Set
        End Property
        Public Property Ingreso15() As Integer
            Get
                Return intIngreso15
            End Get
            Set(ByVal value As Integer)
                intIngreso15 = value
            End Set
        End Property
        Public Property Ingreso16() As Integer
            Get
                Return intIngreso16
            End Get
            Set(ByVal value As Integer)
                intIngreso16 = value
            End Set
        End Property

        Public ReadOnly Property Total() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.Ingreso1 + Me.Ingreso2 + Me.Ingreso3 + Me.Ingreso4 + Me.Ingreso5 _
                + Me.Ingreso6 + Me.Ingreso7 + Me.Ingreso8 + Me.Ingreso9 + Me.Ingreso10 _
                + Me.Ingreso11 + Me.Ingreso12 + Me.Ingreso13 + Me.Ingreso14 + Me.Ingreso15 _
                + Me.Ingreso16

                Return intValue
            End Get
        End Property

#End Region
    End Class
#Region "Cuadro011Col"
    Public Class Cuadro011Col
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
        Public Function Add(ByVal obj As Cuadro011) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro011(ByVal Index As Integer) As Cuadro011
            Get
                Return CType(MyBase.List(Index), Cuadro011)
            End Get
        End Property
    End Class
#End Region
End Namespace

