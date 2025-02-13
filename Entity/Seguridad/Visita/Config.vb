Namespace Visita

    Public Class Config
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property RegionID As Short = -1
        Public Property RegionNombre As String = ""
        Public Property PenalID As Short = -1
        Public Property PenalNombre As String = ""
        Public Property RegimenTipoID() As Short = -1
        Public Property RegimenTipoNombre As String = ""
        Public Property SexoID As Short = -1
        Public Property InicioHora() As Byte = 0
        Public Property InicioMinuto() As Byte = 0
        Public ReadOnly Property InicioHoraMinuto() As String
            Get
                Dim value As String = ""
                value = Me.InicioHora.ToString("00") & ":" & Me.InicioMinuto.ToString("00")
                Return value
            End Get
        End Property
        Public Property FinHora() As Byte = 0
        Public Property FinMinuto() As Byte = 0
        Public ReadOnly Property FinHoraMinuto() As String
            Get
                Dim value As String = ""
                value = Me.FinHora.ToString("00") & ":" & Me.FinMinuto.ToString("00")
                Return value
            End Get
        End Property
        Public Property CapacidadInternos() As Integer = 0
        Public Property CapacidadAforo() As Short = 0
        Public Property CapacidadVisitas() As Integer = 0
        Public Property SolicitaInfoPabellon() As Boolean = False
        Public Property SolicitaAutoRegOrdinario() As Boolean = False
        Public Property SolicitaAutoRegAbogado() As Boolean = False
        Public Property SolicitaModuloPOPE() As Boolean = False
        Public Property HabilitaHuellaDigital As Boolean = False
        Public Property CapturarHuellaValReniec As Boolean = False
        Public Property ValidarVisitanteConReniec As Boolean = False
        Public Property ValidarModVisitaConReniec As Boolean = False

        Public Property HabilitarInternosPJ As Boolean = False
        Public Property HabilitarSancionSede As Boolean = False

        Public Property ValidarModVisitaConMigraciones As Boolean = False
        Public Property ValidarVisitanteConMigraciones As Boolean = False

        Public Property Estado As Short = -1
        Public ReadOnly Property EstadoNombre As String
            Get
                Dim value As String = ""

                Select Case Me.Estado
                    Case 1
                        value = "Activo"
                    Case Else
                        value = "Inactivo"
                End Select
                Return value
            End Get
        End Property

#End Region
    End Class
#Region "ConfigCol"
    Public Class ConfigCol
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
        Public Function Add(ByVal value As Config) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Config) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Config) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Config)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Config
            Get
                Return DirectCast(List(index), Config)
            End Get
            Set(ByVal value As Config)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Config)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Config
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace