'23 07 2015  12.42 pm
Namespace General
    Public Class Parametrica
        Inherits Auditoria.Transaccion        
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property CodigoString As String = ""
        Public Property Nombre() As String=""            
        Public ReadOnly Property NombreLength() As String
            Get
                Return Me.Nombre.Length
            End Get
        End Property
        Public Property estado As Short = -1
        Public ReadOnly Property estadoNombre As String
            Get
                Dim value As String = ""

                Select Case estado
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Vigente"
                    Case 2
                        value = "Historico"
                End Select

                Return value.ToUpper
            End Get
        End Property

#End Region
#Region "Propiedades_RegionPenalSeteado"
        Private intRegionID As Integer = -1
        Private strRegionNombre As String = ""
        Private intPenalID As Integer = -1
        Private strPenalNombre As String = ""
        Private strRegionCodigo As String = ""
        Private strPenalCodigo As String = ""
        Public Property RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property RegionNombre() As String
            Get
                Return strRegionNombre
            End Get
            Set(ByVal value As String)
                strRegionNombre = value
            End Set
        End Property
        Public Property PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property RegionCodigo() As String
            Get
                Return strRegionCodigo
            End Get
            Set(ByVal value As String)
                strRegionCodigo = value
            End Set
        End Property
        Public Property PenalCodigo() As String
            Get
                Return strPenalCodigo
            End Get
            Set(ByVal value As String)
                strPenalCodigo = value
            End Set
        End Property
#End Region
    End Class
#Region "ParametricaCol"
    Public Class ParametricaCol
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
        Public Function Add(ByVal obj As Parametrica) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property parametrica(ByVal Index As Integer) As Parametrica
            Get
                Return CType(MyBase.List(Index), Parametrica)
            End Get
        End Property
    End Class
#End Region
End Namespace
