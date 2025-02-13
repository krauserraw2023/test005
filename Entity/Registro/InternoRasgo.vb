Namespace Registro
    Public Class InternoRasgo
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property InternoIngresoId() As Integer = -1
        Public Property NumIngreso() As String = ""

        Public Property InternoId() As Integer = -1
        'Public Property SedeInternoId As Integer = -1
        Public Property Raza() As Integer = -1
        Public Property CabelloForma() As Integer = -1
        Public Property CabelloColor() As Integer = -1
        Public Property Calvicie() As Integer = -1
        Public Property Menton() As Integer = -1
        Public Property Frente() As Integer = -1
        Public Property CaraForma() As Integer = -1
        Public Property LineaInsercion() As Integer = -1
        Public Property FormaOjo() As Integer = -1
        Public Property Iris() As Integer = -1
        Public Property Cejas() As Integer = -1
        Public Property AnomaliaOjo() As Integer = -1
        Public Property Oreja() As Integer = -1
        Public Property NarizForma() As Integer = -1
        Public Property TipoNariz() As Integer = -1
        Public Property Boca() As Integer = -1
        Public Property Labio() As Integer = -1
        Public Property TipoLabio() As Integer = -1
        Public Property Tronco() As Integer = -1
        Public Property Complexion() As Integer = -1

        Public Property Raza_Nom() As String
        Public Property CabelloForma_Nom() As String = ""
        Public Property CabelloColor_Nom() As String = ""
        Public Property Calvicie_Nom() As String = ""
        Public Property Menton_Nom() As String = ""
        Public Property Frente_Nom() As String = ""
        Public Property CaraForma_Nom() As String = ""
        Public Property LineaInsercion_Nom() As String = ""
        Public Property FormaOjo_Nom() As String = ""
        Public Property Iris_Nom() As String = ""
        Public Property Cejas_Nom() As String = ""
        Public Property AnomaliaOjo_Nom() As String = ""
        Public Property Oreja_Nom() As String = ""
        Public Property NarizForma_Nom() As String = ""
        Public Property TipoNariz_Nom() As String = ""
        Public Property Boca_Nom() As String = ""
        Public Property Labio_Nom() As String = ""
        Public Property TipoLabio_Nom() As String = ""
        Public Property Tronco_Nom() As String = ""
        Public Property Complexion_Nom() As String = ""

        Public Property Talla() As Single = 0
        Public Property Peso() As Single = 0
        Public Property Obs() As String = ""
        Public Property SedeRowId As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoNroInpe As String = ""

        Public Property PenalId As Integer = -1
#End Region
    End Class
#Region "InternoRasgoCol"
    Public Class InternoRasgoCol
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
        Public Function Add(ByVal obj As InternoRasgo) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Internorasgo(ByVal Index As Integer) As InternoRasgo
            Get
                Return CType(MyBase.List(Index), InternoRasgo)
            End Get
        End Property
        Public Function CloneCol() As InternoRasgo
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace