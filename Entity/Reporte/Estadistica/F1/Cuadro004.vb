Namespace Reporte.Estadistica.F1
    Public Class Cuadro004
#Region "Propiedades"
        Private strInstruccion As String = ""
        Private intProcesadoHom As Integer = 0
        Private intProcesadoMuj As Integer = 0
        Private intSentenciaHom As Integer = 0
        Private intSentenciaMuj As Integer = 0
        Private intMixtoHom As Integer = 0
        Private intMixtoMuj As Integer = 0
        Public Property Instruccion() As String
            Get
                Return strInstruccion
            End Get
            Set(ByVal value As String)
                strInstruccion = value
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

        Public Property SentenciaHom() As Integer
            Get
                Return intSentenciaHom
            End Get
            Set(ByVal value As Integer)
                intSentenciaHom = value
            End Set
        End Property
        Public Property SentenciaMuj() As Integer
            Get
                Return intSentenciaMuj
            End Get
            Set(ByVal value As Integer)
                intSentenciaMuj = value
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
                intValue = Me.ProcesadoHom + Me.ProcesadoMuj + Me.SentenciaHom + Me.SentenciaMuj + Me.MixtoHom + Me.MixtoMuj
                Return intValue
            End Get
        End Property
#End Region
    End Class
#Region "Cuadro004Col"
    Public Class Cuadro004Col
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
        Public Function Add(ByVal obj As Cuadro004) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro004(ByVal Index As Integer) As Cuadro004
            Get
                Return CType(MyBase.List(Index), Cuadro004)
            End Get
        End Property
    End Class
#End Region
End Namespace
