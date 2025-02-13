Namespace Seguridad.Paquetes
    Public Class Registro

#Region "Propiedades"
        Public Property codigo() As Integer = -1
        Public Property idVisita() As Integer = -1
        Public Property visitaApellidosNombres() As String = ""
        Public Property visitaNumeroDocumento() As String = ""
        Public Property tipoInterno As Short = 1 '1=interno,2=internopj
        Public Property idInterno As Integer = -1
        Public Property idInternoPJ As Integer = -1
        Public Property internoApellidosNombres() As String = ""
        Public Property idParentesco() As Integer = -1
        Public Property fechaRegistro() As DateTime = Now
        Public Property tipoPaquete As Short = -1
        Public Property tipoPresentacion() As Short = -1
        Public Property tipoPresentacionNombre As String = ""
        Public Property idTipoArticulo() As Integer = -1
        Public Property peso() As Short = 0
        Public Property numeroElementos() As Short = 0
        Public Property entregaDinero As Boolean = False
        Public Property montoDinero As Decimal = 0.0
        Public Property entregaMedicamento As Boolean = False
        Public Property autorizacionNumDoc As String = ""
        Public Property autorizacionFechaDoc As Long = 0
        Public Property observacion() As String = ""
        Public Property idFotoPaquete() As Integer = -1
        Public Property nombreFotoPaquete() As String = ""
        Public Property idRegion As Integer = -1
        Public Property idPenal As Integer = -1
#Region "Busqueda"
        Public Property idVisitaTipoDocumento As Integer = -1
        Public Property fechaInicio As DateTime = Now
        Public Property fechaFin As DateTime = Now
        Public Property internoNumeroDocumento As String = ""
        Public Property filtroEntregaDinero As Short = -1
        Public Property filtroEntregaMedicamento As Short = -1
#End Region
#Region "Grilla"
        Public Property visitaTipoDocumento As String = ""
        Public ReadOnly Property getVisitaTipoDocyNumeroDoc As String
            Get
                Dim value As String = ""
                value = visitaTipoDocumento + " " + visitaNumeroDocumento
                Return value
            End Get
        End Property
        Public Property visitaSexoNombre As String = ""
        Public Property visitaFechaNacimiento As Long = 0
        Public Property visitaEdad As String = ""
        Public Property visitaFotoNombre As String = ""
        Public Property nombreParentesco As String = ""
        Public Property tipoArticuloNombre As String = ""
        Public Property tipoPaqueteNombre As String = ""
        Public ReadOnly Property entregaDineroToString As String
            Get
                Dim value As String = ""

                If Me.entregaDinero = True Then
                    value = "SI"
                Else
                    value = "NO"
                End If
                Return value
            End Get
        End Property
        Public ReadOnly Property entregaMedicamentoToString As String
            Get
                Dim value As String = ""

                If Me.entregaMedicamento = True Then
                    value = "SI"
                Else
                    value = "NO"
                End If
                Return value
            End Get
        End Property
        Public Property autorizacionFechaDocString As String = ""
        Public Property RegionNombre As String = ""
        Public Property PenalNombre As String = ""
#End Region
#End Region
    End Class
#Region "RegistroCol"
    Public Class RegistroCol
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
        Public Function Add(ByVal value As Registro) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Registro) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Registro) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Registro)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Registro
            Get
                Return DirectCast(List(index), Registro)
            End Get
            Set(ByVal value As Registro)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Registro)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Registro
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace