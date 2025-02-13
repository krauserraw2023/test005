Namespace Globall
    Public Class ArchivoDigital
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        '--------------- propiedades antigua version -------------->>>
        Public Property NombreRed() As String = ""
        Public Property DirectorioRed() As String = ""
        Public Property Descripcion() As String = ""
        Public Property VigenciaIni() As Long = 0
        Public Property VigenciaFin() As Long = 0
        '<<<---------------------------------------------------------
        Public Property PC() As String = ""
        Public Property IP() As String = ""
        Public Property Directorio() As String = ""
        Public Property NombreFisico() As String = ""
        Public Property Extension() As String = ""
        Public Property Peso() As Integer = -1
        Public Property FechaCreacion() As Long = 0
        Public Property FechaModificacion() As Long = 0
        Public Property FechaImportacion() As Long = 0
        Public Property Anio As Integer = -1
        Public Property Mes As Integer = 0
        Public Property ArchivoByte() As Byte() = Nothing
        Public Property MesCorrelativo As String = ""
        Public Property MAC As String = ""
        Public Property RutaServidor As String = ""
        Public Property CodigoExt_id As Integer = -1 'IdInterno, IdVisitante, IdReniec valor que depende de tipo
        Public Property Region As Integer = -1
        Public Property Penal As Integer = -1
        Public Property Tipo As Integer = -1 '1:interno,2:Persona,3:visitante,4:reniec,5:ReniecSybase ,6:Odontograma
        Public Property ImagenUploadWeb As Boolean = False 'indica si la imagen se cargo a a la web service
        'Public Property InternoId As Integer = -1
        'ninguna
        Public Property PerfilFoto As String = -1 'perfil de la foto del interno 

        Public Property TipoDocIdentidad() As Integer = 0 'valido para generar el nombre de la foto del visitante
        Public Property NumDocIdentidad() As String = "" 'valido para generar el nombre de la foto del visitante

#End Region
    End Class
#Region "ArchivodigitalCol"
    Public Class ArchivoDigitalCol
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
        Public Function Add(ByVal obj As Archivodigital) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Archivodigital(ByVal Index As Integer) As Archivodigital
            Get
                Return CType(MyBase.List(Index), Archivodigital)
            End Get
        End Property
        Public Function CloneCol() As Archivodigital
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace