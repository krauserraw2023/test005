Namespace Globall
    ''' <summary>
    ''' Representa registro de la tabla glo_mov_arch_digitalizado
    ''' </summary>
    Public Class ArchivoDigitalizado
        Public Property Codigo As Integer = -1
        Public Property TipoArchivoDigital As Integer = -1 '1=odontograma
        Public Property IdRegistroForaneo As Integer = -1 'id foraneo en funcion al tipo de archivo (si es odontograma apunta a la tabla int_mov_interno_odontograma)
        Public Property Anio As Integer = -1
        Public Property Mes As Integer = -1
        Public Property Mac As String = ""
        Public Property NombrePc As String = ""
        Public Property Ip As String = ""
        Public Property NombreArchivo As String = ""
        Public Property Extension As String = ""
        Public Property PesoByte As Integer = 0
        Public Property ArchivoDigitalByte() As Byte() = Nothing
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1
        Public Property SedeRowId As Integer = -1
    End Class
#Region "ArchivoDigitalizadoCol"
    Public Class ArchivoDigitalizadoCol
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
        Public Function Add(ByVal obj As ArchivoDigitalizado) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Archivodigital(ByVal Index As Integer) As ArchivoDigitalizado
            Get
                Return CType(MyBase.List(Index), ArchivoDigitalizado)
            End Get
        End Property
        Public Function CloneCol() As ArchivoDigitalizado
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace