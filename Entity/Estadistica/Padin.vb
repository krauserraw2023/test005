Namespace Estadistica
    Public Class Padin
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private strRegionNombre As String = ""
        Private strPenalNombre As String = ""
        Private strMesNombre As String = ""

        Public Property Codigo() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String
            Get
                Return strRegionNombre
            End Get
            Set(ByVal value As String)
                strRegionNombre = value.ToUpper.Trim
            End Set
        End Property
        Public Property PenalID() As Integer = -1
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre
            End Get
            Set(ByVal value As String)
                strPenalNombre = value.ToUpper.Trim
            End Set
        End Property
        Public Property Numero() As Integer = -1
        Public Property Anio() As Integer = -1
        Public Property Mes() As Integer = -1
        Public Property MesNombre() As String
            Get
                Return strMesNombre
            End Get
            Set(ByVal value As String)
                strMesNombre = value.ToUpper
            End Set
        End Property
        Public Property Fecha As Long = 0
        Public Property FechaProceso As Long = 0
        Public Property FechaEnvio As Long = 0
        Public Property FechaRecepcion As Long = 0
        Public Property Estado As Integer = -1
        Public Property EstadoNombre As String = ""         
        Public Property FechaCorte() As Long = 0
        Public Property Observacion() As String = ""
        Public Property ObservacionAnulacion() As String = ""
        Public Property TieneObs As Boolean
        Public Property Version As Short = -1
        Public Property VersionReporte As Short = -1

        Public Property PadinColor() As System.Drawing.Color = Drawing.Color.White
        Public Property UsuarioCreacion() As String = ""
        Public Property UsuarioModific() As String = ""

        Public Property IDUsuarioResponsableRegion As Integer = -1
        Public Property UsuarioResponsableRegion As String = ""
        Public Property FechaRegionRpta As Long = 0

        Public Property TipoMovimiento As Integer = -1

        Public Property TransferIDRow As Long = -1
        Public Property TransferIDRegion As Integer = -1
        Public Property TransferIDPenal As Integer = -1


        Public ReadOnly Property FechaRecepcionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaRecepcion, True)
            End Get
        End Property
        Public ReadOnly Property FechaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.Fecha, True)
            End Get
        End Property
#End Region
    End Class
#Region "PadinCol"
    Public Class PadinCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, SortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As Padin) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Padin(ByVal Index As Integer) As Padin
            Get
                Return CType(MyBase.List(Index), Padin)
            End Get
        End Property
        Public Function CloneCol() As Padin
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace