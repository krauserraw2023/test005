Namespace Registro
    Public Class InternoReniecNomAsoc
        'Inherits Legolas.LEntity.Globall.Persona--
#Region "Propiedades"
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property CodigoNomAsoc() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property TipoBusquedaID() As Integer = -1
        Public Property ComparacionID() As Integer = -1
        Public Property FotoReniec() As Integer = -1
        Public Property FotoInterno() As Integer = -1

        Public Property InternoSisMetadata() As String = ""
        Public Property InternoSisData() As String = ""
        Public Property NombresAsociados() As String = ""
        Public Property NombresAsociadosID() As String = ""
        Public Property NombresAsociadosNom() As String = ""
        Public Property ReniecMetadata() As String = ""
        Public Property ReniecData() As String = ""
        Public Property Observaciones() As String = ""

        Public Property PthServidor() As String = "" 'ruta servidor de la foto reniec

        Public Property PthServidorFotoInterno() As String = "" 'ruta servidor de la foto del interno
        Public Property NombreFotoInterno() As String = "" 'nombre de la foto del interno dentro de la tabla InternoReniec

        Public Property FechaValidacion As Long = 0
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalNombre() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property FotoTipo() As Integer = -1
        Public Property PFrenteInt As String = ""
        Public Property PFrenteRnc As String = ""
        Public Property PFrenteName As String = "" 'nombre de la foto reniec
        Public Property CodigoHistorial As Integer = -1

        Public Property ApellidoPaterno As String = ""
        Public Property ApellidoMaterno As String = ""
        Public Property Nombres As String = ""
        'Public Property ApellidoPaterno As String = ""
        Public Property InternoReniecID As Integer = -1
        Public Property NombreAsociadoVal_ID() As Integer = -1
        Public Property NombreAsociadoVal_Nom() As String = ""
#End Region
    End Class
#Region "InternoValidadoCol"
    Public Class InternoReniecNomAsocCol
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
        Public Function Add(ByVal obj As InternoReniecNomAsoc) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Historial(ByVal Index As Integer) As InternoReniecNomAsoc
            Get
                Return CType(MyBase.List(Index), InternoReniecNomAsoc)
            End Get
        End Property
    End Class
#End Region
End Namespace

