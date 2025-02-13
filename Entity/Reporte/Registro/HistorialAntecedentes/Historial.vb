Namespace Reporte.HistorialAntecedentes
    Public Class Historial
#Region "Propiedades"
        Private strApellidoPrimero As String = ""
        Private strApellidoSegundo As String = ""
        Private strPreNombres As String = ""
        Private strPenalNombre As String = ""
        Private strPathInternoWeb As String = ""
        Private strFotoPerfilCentral As String = ""
        Private strObservacion As String = ""
        Private strNombresAsociados As String = ""
        Public Property ApellidoPrimero() As String
            Get
                Return strApellidoPrimero
            End Get
            Set(ByVal value As String)
                strApellidoPrimero = value
            End Set
        End Property
        Public Property ApellidoSegundo() As String
            Get
                Return strApellidoSegundo
            End Get
            Set(ByVal value As String)
                strApellidoSegundo = value
            End Set
        End Property
        Public Property PreNombres() As String
            Get
                Return strPreNombres
            End Get
            Set(ByVal value As String)
                strPreNombres = value
            End Set
        End Property
        Public ReadOnly Property ApellidosyPreNombres() As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPrimero & " " & Me.ApellidoSegundo & ", " & Me.PreNombres
                Return value.ToUpper
            End Get
        End Property
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property NombresAsociados() As String
            Get
                Return strNombresAsociados
            End Get
            Set(ByVal value As String)
                strNombresAsociados = value
            End Set
        End Property
#Region "Col"
        Private objAntecedentes As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol = Nothing
        Public Property Antecedentes() As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol
            Get
                Return objAntecedentes
            End Get
            Set(ByVal value As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol)
                objAntecedentes = value
            End Set
        End Property
#End Region
#End Region
    End Class
#Region "HistorialCol"
    Public Class HistorialCol
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
        Public Function Add(ByVal obj As Historial) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Historial(ByVal Index As Integer) As Historial
            Get
                Return CType(MyBase.List(Index), Historial)
            End Get
        End Property
    End Class
#End Region
End Namespace
