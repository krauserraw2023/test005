Namespace Registro
    Public Class AlertaSentenciaDetalle
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
        Public Property FechaIngresoISP As DateTime
        Public Property FechaIngresoPenal As DateTime
        Public Property DocumentoJudTipo As String = ""
        Public Property ExpedienteNumero As String = ""
        Public Property DelitoId As Integer = -1
        Public Property DelitoNombre As String = ""
        Public Property CondenaAnios As Integer = 0
        Public Property CondenaMeses As Integer = 0
        Public Property CondenaDias As Integer = 0
        Public Property PeriodoInicial As String = ""
        Public Property PeriodoFinal As String = ""
        Public Property Tiemporestante As Integer = 0
        Public Property EstadoId As Integer = -1
        Public Property EstadoCabId As Integer = -1
        Public Property Estado As String = ""

        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _Region() As String = ""
        Public Property _Penal() As String = ""

        Public ReadOnly Property TiempoCondena() As String
            Get
                Dim strValor As String
                strValor = Me.CondenaAnios & " año(s) " & Me.CondenaMeses & " mes(es) " & Me.CondenaDias & " dia(s)"
                Return strValor
            End Get
        End Property
        Public ReadOnly Property PeriodoInicialStr() As String
            Get
                Dim strValor As String = Me.PeriodoInicial
                Dim dValor As Date = Nothing
                If strValor.Length = 0 Then
                    strValor = ""
                ElseIf strValor <> "01/01/1900" Then
                    dValor = Me.PeriodoInicial
                    Return dValor
                Else
                    strValor = ""
                End If

                Return strValor
            End Get
        End Property
        Public ReadOnly Property PeriodoFinalStr() As String
            Get
                Dim strValor As Date = Me.PeriodoFinal

                Return strValor
            End Get
        End Property
        Public ReadOnly Property EstadoCabecera() As String
            Get
                Dim strValor As String
                If Me.EstadoCabId = 1 Then
                    strValor = "Pendiente"
                End If
                If Me.EstadoCabId = 2 Then
                    strValor = "No enviado"
                End If
                If Me.EstadoCabId = 3 Then
                    strValor = "Enviado"
                End If
                If Me.EstadoCabId = 4 Then
                    strValor = "Sin datos"
                End If
                Return strValor
            End Get
        End Property
#End Region
    End Class

#Region "AlertaSentenciaCol"
    Public Class AlertaSentenciaDetalleCol
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

        Public Function Add(ByVal obj As AlertaSentenciaDetalle) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property AlertaSentenciaDetalle(ByVal Index As Integer) As AlertaSentenciaDetalle
            Get
                Return CType(MyBase.List(Index), AlertaSentenciaDetalle)
            End Get
        End Property
        Public Function toList() As List(Of AlertaSentenciaDetalle)
            Dim a As New List(Of AlertaSentenciaDetalle)
            For Each i As AlertaSentenciaDetalle In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
