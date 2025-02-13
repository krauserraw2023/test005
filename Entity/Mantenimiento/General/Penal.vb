Namespace General
    Public Class Penal
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        Private strRegionNombre As String = ""

        Public Property Codigo() As Integer = -1
        Public Property PenalCodigo() As String = ""
        Public Property Nombre() As String = ""
        Public Property NombreCorto() As String = ""
        Public Property RegionID() As Integer = -1
        Public Property RegionCodigo() As String = ""
        Public Property RegionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strRegionNombre)
            End Get
            Set(ByVal value As String)
                strRegionNombre = value
            End Set
        End Property
        'Public Property TipoPenal() As Integer = 0
        'Public Property PenalInternos() As Integer = 0
        'Public Property PenalSentenciados() As Integer = 0
        'Public Property PenalProcesados() As Integer = 0
        'Public Property FechaInstalacion() As Long = 0
        Public Property Estado() As Integer = -1
        'Public Property PenalLicencia() As String = ""
        Public Property RegimenPenitenciarioId() As Integer = -1
        'en version futura cambiar obtener desde la tabla SysInstalacion pendienteHnrb
        Public Property PenalTipoLicenciaId As Integer = -1 '7=penal lima provincia,4=Lima metropolitana,6=carceleta,1=Penal Provincia
#End Region
#Region "Otros"
        Public Property FechaInstalacionSistemaVisitas() As Long = 0
        Public Property VersionAPP() As String = "0"
#End Region
#Region "Tranferencia_Archivos"
        Private intImportacionNumero As Integer = 0
        Private lngFechaImportacion As Long = 0

        Public Property ImportacionNumero() As Integer
            Get
                Return intImportacionNumero
            End Get
            Set(ByVal value As Integer)
                intImportacionNumero = value
            End Set
        End Property
        Public Property ImportacionFecha() As Long
            Get
                Return lngFechaImportacion
            End Get
            Set(ByVal value As Long)
                lngFechaImportacion = value
            End Set
        End Property
#End Region
    End Class
#Region "PenalCol"
    Public Class PenalCol
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
        Public Function Add(ByVal obj As Penal) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Penal(ByVal Index As Integer) As Penal
            Get
                Return CType(MyBase.List(Index), Penal)
            End Get
        End Property
    End Class
#End Region
End Namespace
