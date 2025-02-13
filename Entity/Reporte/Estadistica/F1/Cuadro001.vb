Namespace Reporte.Estadistica.F1
    Public Class Cuadro001
#Region "Propiedades"
        Private intTotalGeneralProcesadoH As Integer = 0
        Private intTotalGeneralProcesadoM As Integer = 0
        Private intTotalGeneralSentenciadoH As Integer = 0
        Private intTotalGeneralSentenciadoM As Integer = 0
        Private intTotalGeneralMixtoH As Integer = 0
        Private intTotalGeneralMixtoM As Integer = 0
        
        Public Property TotalGeneralProcesadoH() As Integer
            Get
                Return intTotalGeneralProcesadoH
            End Get
            Set(ByVal value As Integer)
                intTotalGeneralProcesadoH = value
            End Set
        End Property
        Public Property TotalGeneralProcesadoM() As Integer
            Get
                Return intTotalGeneralProcesadoM
            End Get
            Set(ByVal value As Integer)
                intTotalGeneralProcesadoM = value
            End Set
        End Property
        Public ReadOnly Property TotalGeneralProcesado() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.TotalGeneralProcesadoH + Me.TotalGeneralProcesadoM
                Return intValue
            End Get

        End Property
      
        Public Property TotalGeneralSentenciadoH() As Integer
            Get
                Return intTotalGeneralSentenciadoH
            End Get
            Set(ByVal value As Integer)
                intTotalGeneralSentenciadoH = value
            End Set
        End Property
        Public Property TotalGeneralSentenciadoM() As Integer
            Get
                Return intTotalGeneralSentenciadoM
            End Get
            Set(ByVal value As Integer)
                intTotalGeneralSentenciadoM = value
            End Set
        End Property
        Public ReadOnly Property TotalGeneralSentenciado() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.TotalGeneralSentenciadoH + Me.TotalGeneralSentenciadoM
                Return intValue
            End Get
        End Property

        Public Property TotalGeneralMixtoH() As Integer
            Get
                Return intTotalGeneralMixtoH
            End Get
            Set(ByVal value As Integer)
                intTotalGeneralMixtoH = value
            End Set
        End Property
        Public Property TotalGeneralMixtoM() As Integer
            Get
                Return intTotalGeneralMixtoM
            End Get
            Set(ByVal value As Integer)
                intTotalGeneralMixtoM = value
            End Set
        End Property
        Public ReadOnly Property TotalGeneralMixto() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.TotalGeneralMixtoH + Me.TotalGeneralMixtoM
                Return intValue
            End Get
        End Property

        Public ReadOnly Property TotalGeneral() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.TotalHombres + Me.TotalMujeres
                Return intValue
            End Get
        End Property
        Public ReadOnly Property TotalHombres() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.TotalGeneralProcesadoH + Me.TotalGeneralSentenciadoH + Me.TotalGeneralMixtoH
                Return intValue
            End Get
        End Property
        Public ReadOnly Property TotalMujeres() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.TotalGeneralProcesadoM + Me.TotalGeneralSentenciadoM + Me.TotalGeneralMixtoM
                Return intValue
            End Get
        End Property

#End Region
    End Class
#Region "Cuadro001Col"
    Public Class Cuadro001Col
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
        Public Function Add(ByVal obj As Cuadro001) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro001(ByVal Index As Integer) As Cuadro001
            Get
                Return CType(MyBase.List(Index), Cuadro001)
            End Get
        End Property
    End Class
#End Region
End Namespace
