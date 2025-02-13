Namespace Reporte.Estadistica.F1
    Public Class Cuadro003
#Region "Propiedades"
        Private strEdadString As String = ""
        Private intTotalProcesadoH As Integer = 0
        Private intTotalProcesadoM As Integer = 0
        Private intTotalSentenciadoH As Integer = 0
        Private intTotalSentenciadoM As Integer = 0
        Private intTotalMixtoH As Integer = 0
        Private intTotalMixtoM As Integer = 0

        Public Property EdadString() As String
            Get
                Return strEdadString
            End Get
            Set(ByVal value As String)
                strEdadString = value
            End Set
        End Property

        Public Property TotalProcesadoH() As Integer
            Get
                Return intTotalProcesadoH
            End Get
            Set(ByVal value As Integer)
                intTotalProcesadoH = value
            End Set
        End Property
        Public Property TotalProcesadoM() As Integer
            Get
                Return intTotalProcesadoM
            End Get
            Set(ByVal value As Integer)
                intTotalProcesadoM = value
            End Set
        End Property

        Public Property TotalSentenciadoH() As Integer
            Get
                Return intTotalSentenciadoH
            End Get
            Set(ByVal value As Integer)
                intTotalSentenciadoH = value
            End Set
        End Property
        Public Property TotalSentenciadoM() As Integer
            Get
                Return intTotalSentenciadoM
            End Get
            Set(ByVal value As Integer)
                intTotalSentenciadoM = value
            End Set
        End Property

        Public Property TotalMixtoH() As Integer
            Get
                Return intTotalMixtoH
            End Get
            Set(ByVal value As Integer)
                intTotalMixtoH = value
            End Set
        End Property
        Public Property TotalMixtoM() As Integer
            Get
                Return intTotalMixtoM
            End Get
            Set(ByVal value As Integer)
                intTotalMixtoM = value
            End Set
        End Property

        Public ReadOnly Property TotalGeneral() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.TotalProcesadoH + Me.TotalProcesadoM + Me.TotalSentenciadoH + Me.TotalSentenciadoM + Me.TotalMixtoH + Me.TotalMixtoM
                Return intValue
            End Get

        End Property
#End Region
    End Class
#Region "Cuadro003Col"
    Public Class Cuadro003Col
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
        Public Function Add(ByVal obj As Cuadro003) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro003(ByVal Index As Integer) As Cuadro003
            Get
                Return CType(MyBase.List(Index), Cuadro003)
            End Get
        End Property
    End Class
#End Region
End Namespace
