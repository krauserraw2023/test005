Namespace Registro
    Public Class InternoSenaParticular
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property SedeRowId As Integer = -1
        Private strNaturalezaNombre As String = ""
        Private strFormaNombre As String = ""
        Private strUbicacionNombre As String = ""
        Private strPosicionNombre As String = ""
        Private strObs As String = ""
        Public Property InternoIngresoId() As Integer = -1
        Public Property NumIngreso() As String = ""
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property NaturalezaID() As Integer = -1
        Public Property NaturalezaNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNaturalezaNombre)
            End Get
            Set(ByVal value As String)
                strNaturalezaNombre = value
            End Set
        End Property
        Public Property FormaID() As Integer = -1
        Public Property FormaNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strFormaNombre)
            End Get
            Set(ByVal value As String)
                strFormaNombre = value
            End Set
        End Property
        Public Property UbicacionID() As Integer = -1
        Public Property UbicacionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strUbicacionNombre)
            End Get
            Set(ByVal value As String)
                strUbicacionNombre = value
            End Set
        End Property
        Public Property PosicionID() As Integer = -1
        Public Property PosicionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strPosicionNombre)
            End Get
            Set(ByVal value As String)
                strPosicionNombre = value
            End Set
        End Property
        'Public Property Cantidad() As Integer
        '    Get
        '        Return intCantidad
        '    End Get
        '    Set(ByVal value As Integer)
        '        intCantidad = value
        '    End Set
        'End Property
        Public Property Cantidad() As Integer = 1
        Public Property Obs() As String = ""
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoNroInpe As String = ""
        '----------------- filtro ----------------------
        Public Property PenalId As Integer = -1
#End Region
    End Class
#Region "InternosenaparticularCol"
    Public Class InternoSenaParticularCol
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
        Public Function Add(ByVal obj As Internosenaparticular) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Internosenaparticular(ByVal Index As Integer) As Internosenaparticular
            Get
                Return CType(MyBase.List(Index), InternoSenaParticular)
            End Get
        End Property
        Public Function CloneCol() As Internosenaparticular
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace