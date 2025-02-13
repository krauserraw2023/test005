Namespace Reporte.Estadistica.F1
    Public Class Cuadro009
#Region "Propiedades"
        Private intProcesadosHom As Integer = 0
        Private intProcesadosMuj As Integer = 0
        Private intSetenciadoHom As Integer = 0
        Private intSetenciadoMuj As Integer = 0
        Private intMixtoHom As Integer = 0
        Private intMixtoMuj As Integer = 0
        Public Property TipoComunidad As String = ""
        Public Property ProcesadosHom() As Integer
            Get
                Return intProcesadosHom
            End Get
            Set(ByVal value As Integer)
                intProcesadosHom = value
            End Set
        End Property
        Public Property ProcesadosMuj() As Integer
            Get
                Return intProcesadosMuj
            End Get
            Set(ByVal value As Integer)
                intProcesadosMuj = value
            End Set
        End Property

        Public Property SetenciadoHom() As Integer
            Get
                Return intSetenciadoHom
            End Get
            Set(ByVal value As Integer)
                intSetenciadoHom = value
            End Set
        End Property
        Public Property SetenciadoMuj() As Integer
            Get
                Return intSetenciadoMuj
            End Get
            Set(ByVal value As Integer)
                intSetenciadoMuj = value
            End Set
        End Property

        Public Property MixtoHom() As Integer
            Get
                Return intMixtoHom
            End Get
            Set(ByVal value As Integer)
                intMixtoHom = value
            End Set
        End Property
        Public Property MixtoMuj() As Integer
            Get
                Return intMixtoMuj
            End Get
            Set(ByVal value As Integer)
                intMixtoMuj = value
            End Set
        End Property

        Public ReadOnly Property Total() As Integer
            Get
                Dim intValue As Integer = 0

                intValue = Me.ProcesadosHom + Me.ProcesadosMuj + Me.SetenciadoHom + Me.SetenciadoMuj + Me.MixtoHom + Me.MixtoMuj

                Return intValue
            End Get
        End Property
#End Region
    End Class
#Region "Cuadro009Col"
    Public Class Cuadro009Col
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
        Public Function Add(ByVal obj As Cuadro009) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro009(ByVal Index As Integer) As Cuadro009
            Get
                Return CType(MyBase.List(Index), Cuadro009)
            End Get
        End Property
    End Class
#End Region
End Namespace
