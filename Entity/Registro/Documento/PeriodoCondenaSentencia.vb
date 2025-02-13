Namespace Registro.Documento
    Public Class PeriodoCondenaSentencia
        Inherits Auditoria.Transaccion

#Region "Propiedades"

        Public Property FlagTransferenciaSede As Integer = 0
        Public Property Codigo As Integer = -1
        Public Property InternoId As Integer = -1
        Public Property IngresoId As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property FechaInicio As Long = 0
        Public Property FechaFin As Long = 0
        Public Property Anio As Integer = 0
        Public Property Mes As Integer = 0
        Public Property Dia As Integer = 0
        Public Property DocJudicialId As Integer = -1 'para relacionar con la resolucion de sentencia (documento judicial)
        Public Property Tipo As Integer = -1
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1

        Public ReadOnly Property FechaInicioString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInicio)
            End Get
        End Property
        Public ReadOnly Property FechaFinString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaFin)
            End Get
        End Property
        Public Property fechaAnhos As Integer = 0
        Public Property fechaMeses As Integer = 0
        Public Property fechaDias As Integer = 0
        'variables auxiliares'(no provienen de BD)
        Public Property PeriodoCondenaItem As Integer = 0
        Public Property FlgEliminado() As Boolean = False
        Public Property ValorRef As Boolean = False
#End Region
        Public Function Copiar_PeriodoCondenaSentencia() As PeriodoCondenaSentencia
            Dim ObjEntDestino As New Entity.Registro.Documento.PeriodoCondenaSentencia

            With ObjEntDestino
                .Codigo = Me.Codigo
                .FechaInicio = Me.FechaInicio
                .FechaFin = Me.FechaFin
                .DocJudicialId = Me.DocJudicialId
                .RegionId = Me.RegionId
                .PenalId = Me.PenalId
            End With
            Return ObjEntDestino
        End Function
    
    End Class

    Public Class PeriodoCondenaSentenciaCol
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
        Public Function Add(ByVal obj As PeriodoCondenaSentencia) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property PeriodoCondenaSentencia(ByVal Index As Integer) As PeriodoCondenaSentencia
            Get
                Return CType(MyBase.List(Index), PeriodoCondenaSentencia)
            End Get
        End Property
        Public Function Remove(index As Integer) As Boolean
            Try
                'MyBase.List.RemoveAt(index)
                Me.PeriodoCondenaSentencia(index).FlgEliminado = True
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
        
    End Class
End Namespace
