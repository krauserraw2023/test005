Namespace Reporte.Visita

    Public Class SancionInterno
        Inherits Legolas.LEntity.Globall.Persona
#Region "Propiedades"
        Private strPenal As String = ""
        Private lngFechaSancion As Long = 0
        Private strMotivo As String = ""
        Private strDocumento As String = ""
        Private lngFechaSancionIni As Long = 0
        Private lngFechaSancionFin As Long = 0
        Public Property Penal() As String
            Get
                Return strPenal
            End Get
            Set(ByVal value As String)
                strPenal = value.ToUpper
            End Set
        End Property
        Public Property FechaSancion() As Long
            Get
                Return lngFechaSancion
            End Get
            Set(ByVal value As Long)
                lngFechaSancion = value
            End Set
        End Property
        Public ReadOnly Property FechaSancionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaSancion)
            End Get
        End Property
        Public Property FechaSancionIni() As Long
            Get
                Return lngFechaSancionIni
            End Get
            Set(ByVal value As Long)
                lngFechaSancionIni = value
            End Set
        End Property
        Public ReadOnly Property FechaSancionIniString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaSancionIni)
            End Get
        End Property
        Public Property FechaSancionFin() As Long
            Get
                Return lngFechaSancionFin
            End Get
            Set(ByVal value As Long)
                lngFechaSancionFin = value
            End Set
        End Property
        Public ReadOnly Property FechaSancionFinString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaSancionFin)
            End Get
        End Property
        Public Property Motivo() As String
            Get
                Return strMotivo
            End Get
            Set(ByVal value As String)
                strMotivo = value
            End Set
        End Property
        Public Property Documento() As String
            Get
                Return strDocumento
            End Get
            Set(ByVal value As String)
                strDocumento = value
            End Set
        End Property
#End Region
    End Class
#Region "SancionInternoCol"
    Public Class SancionInternoCol
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
        Public Function Add(ByVal obj As SancionInterno) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property SancionInterno(ByVal Index As Integer) As SancionInterno
            Get
                Return CType(MyBase.List(Index), SancionInterno)
            End Get
        End Property
        Public Function CloneCol() As SancionInterno
            Return MyBase.MemberwiseClone
        End Function
        Public Sub Remove(ByVal index As Integer)
            If index <= Count - 1 OrElse index >= 0 Then
                Me.List.RemoveAt(index)
                'Me.List.Remove(index)
            End If
        End Sub
    End Class
#End Region
End Namespace
