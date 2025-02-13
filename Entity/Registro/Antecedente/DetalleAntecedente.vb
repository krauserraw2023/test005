Namespace Registro.Antecedente
    Public Class DetalleAntecedente
        Public Property Codigo As Integer = -1
        Public Property Fecha As Long = 0
        Public Property Detalle As String = ""
        Public Property Descripcion As String = ""
        Public Property PenalId As Integer = -1
        Public Property RegionId As Integer = -1
        Public Property SolicitudAntecedenteId As Integer = -1

        Public Property TipoDocJudicialId As Integer = -1
        Public Property FechaRecepDocLong As Long = 0
        Public Property NumOrden As Int16 = 0
        Public Property IngresoNum As Int16 = 0
        Public Property FechaDocLong As Long = 0
        Public Property FechaCreaReg As Long = 0
        Public Property DocJudicialEstadoId As Integer = -1 '1=Normal(sin anulaciones), 2=Anulado parcial, 3=Anulado total
        Public Property IngresoInpeId As Integer = -1
        Public Property IDIngreso As Integer = -1 'solo para penales
        '-----------------------
        Public ReadOnly Property FechaStr As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
            End Get
        End Property
    End Class


    Public Class DetalleAntecedenteCol
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
        Public Function Add(ByVal obj As DetalleAntecedente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DetalleAntecedente(ByVal Index As Integer) As DetalleAntecedente
            Get
                Return CType(MyBase.List(Index), DetalleAntecedente)
            End Get
        End Property
    End Class

End Namespace