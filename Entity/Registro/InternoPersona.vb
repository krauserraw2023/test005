Namespace Registro
    Public Class InternoPersona
        Inherits Legolas.LEntity.Globall.Persona
#Region "Propiedades"
        Public Property DigitoVerificacion As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property TipoBusquedaID() As Integer = -1
        Public Property ComparacionID() As Integer = -1
        Public Property FotoReniec() As Integer = -1
        Public Property FotoInterno() As Integer = -1

        Public Property ApellidoCasada As String = ""
        Public Property UbigeoDepProvDist() As String = ""
        Public Property GradoInstruccionNombre As String = ""
        Public Property Estatura() As String = ""
        Public Property NacimientoDepProvDist() As String = ""
        Public Property NombrePadre() As String = ""
        Public Property NombreMadre() As String = ""
        Public Property Restriccion() As String = ""

        Public Property FechaInscripcion() As String = "" 'ruta servidor de la foto reniec

        Public Property FechaExpedicion() As String = "" 'ruta servidor de la foto del interno
        Public Property FechaNacimiento2() As String = "" 'nombre de la foto del interno dentro de la tabla InternoReniec

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

        
#End Region
    End Class
#Region "InternoValidadoCol"
    Public Class InternoPersonaCol
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
        Public Function Add(ByVal obj As InternoPersona) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Historial(ByVal Index As Integer) As InternoPersona
            Get
                Return CType(MyBase.List(Index), InternoPersona)
            End Get
        End Property
    End Class
#End Region
End Namespace

