Namespace Registro
    Public Class DocumentoDescarga
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        Public Property FlagTransferenciaSede As UShort = 0
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property DocumentoTipo() As Integer = -1
        Public Property DocumentoCategoria() As Integer = -1
        Public Property DocumentoNumero() As String = ""

        Public Property DocumentoNumeroTraslado() As String = ""
        Public Property DocumentoFecha() As Long = 0
        Public Property DocumentoFechaRecepcion() As Long = 0
        Public Property PenalNombre() As String = ""
        Public Property RegionNombre() As String = ""

        Public Property DistritoJudicial() As Integer = -1
        Public Property SalaJuzgado() As Integer = -1

        Public Property JuezNombre() As String = ""
        Public Property ApellidosNombres() As String = ""
        Public Property AutoridadOtroNombre() As String = ""
        Public Property AutoridadOtroCargo() As String = ""
        Public Property Observacion() As String = ""
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        'Public Property _EliminadoReg() As Boolean = False


        'version 02, 21-05-2014
        Public Property NumLibro As String = ""
        Public Property NumFolio As String = ""
        Public Property RegionOrigenId As Integer = -1
        Public Property PenalOrigenId As Integer = -1
        Public Property PenalOrigenNom As String = ""
        Public Property RegionDestinoId As Integer = -1
        Public Property PenalDestinoid As Integer = -1
        Public Property PenalDestinoNom As String = ""
        Public Property PenalOtroOrigenNom As String = ""
        Public Property PenalDestinoOtroNom As String = ""
        Public Property FechaMovimiento As Long = 0
        Public Property InternoId As Integer = -1


        Public Property SituacionJuridicaId As Integer = -1 'situacion juridica del interno
        Public Property Flagrancia As Boolean = 0
        Public Property ProlonDetencionFechIni As Long = 0 'fecha de inicio para resolucion de prolongacion de detencion
        Public Property ProlonDetencionFechFin As Long = 0 'fecha de fin para resolucion de prolongacion de detencion
        Public Property ProlonDetencionTipoUnidad As String = "" 'tipo de unidad Ddia, M:mes, A:año, prolongacion de detencion
        Public Property ProlonDetencionValor As Integer = 0 'valor en funcion al tipo de unidad - Prolongacion de detencion

        Public Property DocumentoTipoNombre() As String = ""
        Public Property DocumentoSubTipoNombre() As String = ""

        Public Property Estado() As Integer = -1
        Public Property DistritoJudNombre As String = ""
        Public Property SalaJudNombre As String = ""
        Public Property Eliminado As Boolean = False
        Public ReadOnly Property DocumentoFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.DocumentoFecha, True)
            End Get
        End Property

        Public ReadOnly Property FechaMovimientoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaMovimiento, True)
            End Get
        End Property



        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.Estado
                    Case 0 'anulado
                        value = "ANULADO"
                    Case 1 'activo
                        value = "ACTIVO"
                End Select

                Return value
            End Get
        End Property

#End Region
    End Class

#Region "DocumentoDescargaCol"
    Public Class DocumentoDescargaCol
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

        Public Function Add(ByVal obj As DocumentoDescarga) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DocumentoDescarga(ByVal Index As Integer) As DocumentoDescarga
            Get
                Return CType(MyBase.List(Index), DocumentoDescarga)
            End Get
        End Property
        Public Function toList() As List(Of DocumentoDescarga)
            Dim a As New List(Of DocumentoDescarga)
            For Each i As DocumentoDescarga In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
