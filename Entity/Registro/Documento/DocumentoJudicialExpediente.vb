Namespace Registro.Documento
    Public Class DocumentoJudicialExpediente
        Inherits Auditoria.Transaccion
#Region "Propiedades"        
        Public Property DocJudicialId As Integer = -1
        Public Property IDExpediente As Integer = -1
        Public Property InternoId As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1

        '************* propiedades complementarias ****************
        Public ReadOnly Property Eliminar() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image
                objImagen = My.Resources.delete_32
                Return objImagen
            End Get

        End Property
        Public Property NumDocumentoJudicial() As String = ""
        Public Property NumExpe() As String = ""
        Public Property TipoAutoridadID() As Integer = -1
        Public Property TipoAutoridadNombre() As String = ""
        Public Property AutoridadJudicialNombre() As String = ""
        Public Property SalaJudicialNombre() As String = ""
        Public Property SitJuridicaNombre() As String = ""
        Public Property JuezNombre() As String = ""
        Public Property SecretarioNombre() As String = ""
        Public Property EstadoExpediente() As Integer = -1
        'Public Property InternoIngresoExpediente() As Long = 0
        Public Property FechaDocumentoJudicial() As Long = 0
        Public Property FechaDocumentoJudicialRecepcion() As Long = 0
        Public ReadOnly Property strFechaDocumentoJudicial() As String
            Get
                Dim strFecha As String = ""
                If FechaDocumentoJudicial > 0 Then
                    strFecha = Legolas.Components.FechaHora.FechaDate(FechaDocumentoJudicial, True)
                End If
                Return strFecha
            End Get
        End Property
        Public ReadOnly Property strFechaDocumentoJudicialRecepcion() As String
            Get
                Dim strFecha As String = ""
                If FechaDocumentoJudicial > 0 Then
                    strFecha = Legolas.Components.FechaHora.FechaDate(FechaDocumentoJudicialRecepcion, True)
                End If
                Return strFecha
            End Get
        End Property
        Public Property IDTipoDocumento As Integer = -1
        Public Property IDSubTipoDocumento As Integer = -1
        Public Property TipoNombre As String = ""
        Public Property NroIngreso As String = ""
        Public Property IDIngreso As Integer = -1
        Public Property IngresoInpeID As Integer = -1
        Public Property MovMotivoNombre As String = ""
        Public Property PenalOrigenID() As Integer = -1
        Public Property PenaDestinoID() As Integer = -1
        Public Property PenalOrigenNom() As String = ""
        Public Property PenaDestinoNom() As String = ""
        Public Property Libro() As String = ""
        Public Property Folio() As String = ""
        Public Property SedeRowId As Integer = -1
#End Region

    End Class

#Region "DocumentoJudicialCol"
    Public Class DocumentoJudicialExpedienteCol
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
        Public Function Add(ByVal obj As DocumentoJudicialExpediente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DocumentoJudicial(ByVal Index As Integer) As DocumentoJudicialExpediente
            Get
                Try
                    Return CType(MyBase.List(Index), DocumentoJudicialExpediente)
                Catch ex As Exception
                    Return Nothing
                End Try

            End Get
        End Property
        Public Sub Delete(Index As Integer)
            MyBase.List.RemoveAt(Index)
        End Sub
        Public Sub EliminarDocJudExpe(IdIntExpediente As Integer)
            If IdIntExpediente < 0 Then Exit Sub

            Dim cant As Integer = 0
            cant = MyBase.List.Count
            For i As Integer = 0 To cant - 1
                If CType(MyBase.List(i), DocumentoJudicialExpediente).IDExpediente = IdIntExpediente Then
                    MyBase.List.RemoveAt(i)
                    Exit Sub
                End If
            Next

        End Sub
    End Class
#End Region
End Namespace
