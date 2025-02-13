Namespace Reporte.Estadistica.F1
    Public Class Cuadro005
#Region "Propiedades"
        Private intTipocupacionID As Integer = -1
        Private strTipoOcupacion As String = ""
        Private strGrupoOcupacion As String = ""
        Private strProfesion As String = ""
        Private intHombres As Integer = 0
        Private intMujeres As Integer = 0
        Public Property TipoOcupacionID() As Integer
            Get
                Return intTipocupacionID
            End Get
            Set(ByVal value As Integer)
                intTipocupacionID = value
            End Set
        End Property
        Public Property TipoOcupacion() As String
            Get
                Return strTipoOcupacion.ToUpper
            End Get
            Set(ByVal value As String)
                strTipoOcupacion = value
            End Set
        End Property
        Public Property GrupoOcupacion() As String
            Get
                Return strGrupoOcupacion.ToUpper
            End Get
            Set(ByVal value As String)
                strGrupoOcupacion = value
            End Set
        End Property
        Public Property Ocupacion() As String
            Get
                Return strProfesion.ToUpper
            End Get
            Set(ByVal value As String)
                strProfesion = value
            End Set
        End Property
        Public Property Hombres() As Integer
            Get
                Return intHombres
            End Get
            Set(ByVal value As Integer)
                intHombres = value
            End Set
        End Property
        Public Property Mujeres() As Integer
            Get
                Return intMujeres
            End Get
            Set(ByVal value As Integer)
                intMujeres = value
            End Set
        End Property
        Public ReadOnly Property Total() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.Hombres + Me.Mujeres
                Return intValue
            End Get
        End Property
#End Region
    End Class
#Region "Cuadro005Col"
    Public Class Cuadro005Col
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
        Public Function Add(ByVal obj As Cuadro005) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro005(ByVal Index As Integer) As Cuadro005
            Get
                Return CType(MyBase.List(Index), Cuadro005)
            End Get
        End Property
    End Class
#End Region
End Namespace
