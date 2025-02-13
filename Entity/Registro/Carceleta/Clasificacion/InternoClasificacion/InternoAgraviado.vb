Namespace Clasificacion.InternoClasificacion
    Public Class Agraviado
#Region "Propiedades"

        Private strAutoridadSentenciaNombre As String = ""
        Private strObservacion As String = ""

        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property ExpedienteID() As Integer = -1
        Public Property FichaFinalId() As Integer = -1
        Public Property ExpedienteIDAux() As Integer = -1
        Public Property DelitoID() As Integer = -1
        Public Property AgraviadoItem() As Integer = -1
        Public Property DelitoItem() As Integer = -1
        Public Property ExpedienteItem() As Integer = -1
        Public Property AgraviadoNombre() As String = ""
        Public Property SentenciaDocumento() As String = ""
        Public Property SentenciaFecha() As Long = 0
        Public ReadOnly Property SentenciaFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.SentenciaFecha)
            End Get
        End Property
        Public Property SentenciaAnio() As Integer = 0
        Public Property SentenciaMes() As Integer = -1
        Public Property SentenciaDia() As Integer = -1
        Public Property AutoridadJudicial() As Integer = -1
        Public Property AutoridadJudicialNombre() As String
            Get
                Return UCase(strAutoridadSentenciaNombre) ' Legolas.Components.Cadena.ProperCase(strAutoridadSentenciaNombre)
            End Get
            Set(ByVal value As String)
                strAutoridadSentenciaNombre = value
            End Set
        End Property
        Public Property SalaJudicial() As Integer = -1
        Public Property CadenaPerpetua() As Boolean = False
        Public Property FechaIni() As Long = 0
        Public Property FechaFin() As Long = 0
        Public Property Observacion() As String
            Get
                Return UCase(strObservacion)
            End Get
            Set(value As String)
                strObservacion = value
            End Set
        End Property
        Public Property Estado() As Integer = Type.Enumeracion.EstadoNulidadRegistro.EnumEstadoNulidadRegistro.Activo
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property CreaDocJudicialId() As Integer = -1 'documento judicial (resolucion) con la cual se crea el exp.-> 26-06-2014 x hnrb
        Public Property TipoSentenciaId() As Integer = -1
        Public Property TipoResolucionId() As Integer = -1

        Public Property TipoSentenciaHistoricoId() As Integer = -1
        Public Property TipoSentenciaHistoricoNombre() As String = ""

        Public ReadOnly Property TipoSentenciaNombre() As String
            Get
                Dim valor As String = ""
                Select Case TipoSentenciaId
                    Case 12
                        valor = "CONDENATORIA"
                    Case 13
                        valor = "SUSPENDIDA CONDICIONAL"
                    Case 14
                        valor = "SOBRESEIDO"
                    Case 15
                        valor = "NO HABER MERITO PARA PASAR A JUICIO ORAL"
                    Case 16
                        valor = "COMPURGADA"
                    Case 17
                        valor = "PENDIENTE"
                    Case 18
                        valor = "EXCEPCION DE COSA JUZGADA"
                    Case 19
                        valor = "ABSOLUTORIA"
                    Case Else
                        valor = ""
                End Select
                Return valor
            End Get
        End Property

        'Public Property TipoSentenciaNombre As String = ""
        '**** propiedades axiliariares
        Public Property FlgEliminado() As Boolean = False

#End Region
    End Class
#Region "AgraviadoCol"
    Public Class AgraviadoCol
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
        Public Function Add(ByVal obj As Agraviado) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public Function Delete(Index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(Index)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Function Remove(index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(index)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
        Public Sub Remove(ByVal value As Agraviado)
            List.Remove(value)
        End Sub
        Public ReadOnly Property Item(ByVal Index As Integer) As Agraviado
            Get
                Try
                    Return CType(MyBase.List(Index), Agraviado)
                Catch ex As Exception
                    Return Nothing
                End Try

            End Get
        End Property

    End Class
#End Region
End Namespace
