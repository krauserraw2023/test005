Namespace Reporte.Estadistica.F1
    Public Class Cuadro002A
#Region "Propiedades"
        Private strDelitoGenerico As String = ""
        Private strDelitoEspecifico As String = ""
        Private intProcesadoHom As Integer = 0
        Private intProcesadoMuj As Integer = 0
        Private intSentenciadoHom As Integer = 0
        Private intSentenciadoMuj As Integer = 0
        Private intMixtoHom As Integer = 0
        Private intMixtoMuj As Integer = 0
        Public Property DelitoGenerico() As String
            Get
                Return strDelitoGenerico
            End Get
            Set(ByVal value As String)
                strDelitoGenerico = value
            End Set
        End Property
        Public Property DelitoEspecifico() As String
            Get
                Return strDelitoEspecifico
            End Get
            Set(ByVal value As String)
                strDelitoEspecifico = value
            End Set
        End Property

        Public Property ProcesadoHom() As Integer
            Get
                Return intProcesadoHom
            End Get
            Set(ByVal value As Integer)
                intProcesadoHom = value
            End Set
        End Property
        Public Property ProcesadoMuj() As Integer
            Get
                Return intProcesadoMuj
            End Get
            Set(ByVal value As Integer)
                intProcesadoMuj = value
            End Set
        End Property

        Public Property SentenciadoHom() As Integer
            Get
                Return intSentenciadoHom
            End Get
            Set(ByVal value As Integer)
                intSentenciadoHom = value
            End Set
        End Property
        Public Property SentenciadoMuj() As Integer
            Get
                Return intSentenciadoMuj
            End Get
            Set(ByVal value As Integer)
                intSentenciadoMuj = value
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
                intValue = Me.ProcesadoHom + Me.ProcesadoMuj + Me.SentenciadoHom + Me.SentenciadoMuj + Me.MixtoHom + Me.MixtoMuj

                Return intValue
            End Get
        End Property
#End Region
    End Class
#Region "Cuadro002ACol"
    Public Class Cuadro002ACol
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
        Public Function Add(ByVal obj As Cuadro002A) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro002A(ByVal Index As Integer) As Cuadro002A
            Get
                Return CType(MyBase.List(Index), Cuadro002A)
            End Get
        End Property
    End Class
#End Region
End Namespace
