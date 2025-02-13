Namespace Clasificacion.InternoClasificacion
    Public Class Resultado
        Inherits Auditoria.Transaccion
        Private intCodigo As Integer = -1
        Private intInternoClasificacionID As Integer = -1
        Private intInternoClasificacionFichaId As Integer = -1
        Private intInternoID As Integer = -1
        Private intIngresoID As Integer = -1
        Private intFichaID As Integer = -1
        Private intVariableId As Integer = -1
        Private intSecuencia As Integer = -1
        Private strVariableNombre As String = ""
        Private strVariableDescripcion As String = ""
        Private intValorId As Integer = -1
        Private strValorDescripcion As String = ""
        Private decValorNota As Decimal = 0
#Region "Propiedades"
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property InternoClasificacionID() As Integer
            Get
                Return intInternoClasificacionID
            End Get
            Set(ByVal value As Integer)
                intInternoClasificacionID = value
            End Set
        End Property
        Public Property InternoClasificacionFichaId() As Integer
            Get
                Return intInternoClasificacionFichaId
            End Get
            Set(ByVal value As Integer)
                intInternoClasificacionFichaId = value
            End Set
        End Property
        Public Property InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
        Public Property IngresoID() As Integer
            Get
                Return intIngresoID
            End Get
            Set(ByVal value As Integer)
                intIngresoID = value
            End Set
        End Property
        Public Property FichaID() As Integer
            Get
                Return intFichaID
            End Get
            Set(ByVal value As Integer)
                intFichaID = value
            End Set
        End Property
        Public Property VariableId() As Integer
            Get
                Return intVariableId
            End Get
            Set(ByVal value As Integer)
                intVariableId = value
            End Set
        End Property
        Public Property Secuencia() As Integer
            Get
                Return intSecuencia
            End Get
            Set(ByVal value As Integer)
                intSecuencia = value
            End Set
        End Property
        Public Property VariableNombre() As String
            Get
                Return strVariableNombre
            End Get
            Set(ByVal value As String)
                strVariableNombre = value
            End Set
        End Property
        Public Property VariableDescripcion() As String
            Get
                Return strVariableDescripcion
            End Get
            Set(ByVal value As String)
                strVariableDescripcion = value
            End Set
        End Property
        Public Property ValorId() As Integer
            Get
                Return intValorId
            End Get
            Set(ByVal value As Integer)
                intValorId = value
            End Set
        End Property
        Public Property ValorDescripcion() As String
            Get
                Return strValorDescripcion
            End Get
            Set(ByVal value As String)
                strValorDescripcion = value
            End Set
        End Property
        Public Property ValorNota() As Decimal
            Get
                Return decValorNota
            End Get
            Set(ByVal value As Decimal)
                decValorNota = value
            End Set
        End Property
#End Region
    End Class
#Region "ResultadoCol"
    Public Class ResultadoCol
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
        Public Function Add(ByVal obj As Resultado) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Resultado(ByVal Index As Integer) As Resultado
            Get
                Return CType(MyBase.List(Index), Resultado)
            End Get
        End Property
    End Class
#End Region
End Namespace
