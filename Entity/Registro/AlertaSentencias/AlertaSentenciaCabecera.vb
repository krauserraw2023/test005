Namespace Registro
    Public Class AlertaSentenciaCabecera
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        Public Property FlagTransferenciaSede As UShort = 0
        Public Property _TipoLicencia As Integer '--Type.Enumeracion.Licencia.enmTipoLicencia
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property Numero() As String = ""
        Public Property Item As Integer = -1
        Public Property Titulo() As String = ""
        Public Property SentenciasPendientes As Integer = -1
        Public Property SentenciasVencidas() As Integer = -1
        Public Property FechaConsulta() As String = ""
        Public Property FechaInicial() As Date
        Public Property FechaFinal() As Date


        Public Property CodigoDetalle() As Integer = -1
        Public Property InternoId As Integer = -1
        Public Property CodigoRP As String = ""
        Public Property ApellidoPaterno As String = ""
        Public Property ApellidoMaterno As String = ""
        Public Property Nombres As String = ""
        Public Property Nacionalidad As String = ""
        Public Property FechaIngresoISP As Integer = -1
        Public Property FechaIngresoPenal As Integer = -1
        Public Property ExpedienteNumero As String = ""
        Public Property Delito As String = ""
        Public Property CondenaAnios As Integer = 0
        Public Property CondenaMeses As Integer = 0
        Public Property CondenaDias As Integer = 0
        Public Property PeriodoInicial As String = ""
        Public Property PeriodoFinal As String = ""
        Public Property Tiemporestante As String = ""
        Public Property Estado As String = ""

        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _Region() As String = ""
        Public Property _Penal() As String = ""
#End Region
    End Class

#Region "AlertaSentenciaCol"
    Public Class AlertaSentenciaCabeceraCol
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

        Public Function Add(ByVal obj As AlertaSentenciaCabecera) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property AlertaSentenciaCabecera(ByVal Index As Integer) As AlertaSentenciaCabecera
            Get
                Return CType(MyBase.List(Index), AlertaSentenciaCabecera)
            End Get
        End Property
        Public Function toList() As List(Of AlertaSentenciaCabecera)
            Dim a As New List(Of AlertaSentenciaCabecera)
            For Each i As AlertaSentenciaCabecera In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
