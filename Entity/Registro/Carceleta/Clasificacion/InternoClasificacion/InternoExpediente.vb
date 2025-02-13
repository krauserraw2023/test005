Namespace Clasificacion.InternoClasificacion
    Public Class Expediente
#Region "Propiedades_Expediente"
        Private strAutoridadJudicialNombre As String = ""
        Private strSalaJudicialNombre As String = ""
        Private strSituacionJuridicaNombre As String = ""
        Public Property Codigo() As Integer = -1
        Public Property FichaFinalId() As Integer = -1
        'Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property Internamiento() As Boolean = False
        Public Property TipoAutoridadJudicialID As Integer = -1
        Public Property AutoridadJudicialID() As Integer = -1

        Public Property AutoridadJudicialNombre() As String
            Get
                Return UCase(strAutoridadJudicialNombre)
            End Get
            Set(ByVal value As String)
                strAutoridadJudicialNombre = value
            End Set
        End Property
        Public Property SalaJudicialID() As Integer = -1
        Public Property SalaJudicialNombre() As String
            Get
                Return UCase(strSalaJudicialNombre)
            End Get
            Set(ByVal value As String)
                strSalaJudicialNombre = value
            End Set
        End Property
        Public Property ExpedienteJuez() As String = ""
        Public Property ExpedienteSecretario() As String = ""
        Public Property ExpedienteNumero() As String = ""
        Public Property ExpedienteFechaDocRecepcion() As Long = 0
        Public Property ExpedienteFecha() As Long = 0
        Public ReadOnly Property ExpedienteFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.ExpedienteFecha)
            End Get
        End Property
        Public Property SituacionJuridicaID() As Integer = -1
        Public Property SituacionJuridicaNombre() As String
            Get
                If strSituacionJuridicaNombre = "SENTENCIADO" Then
                    strSituacionJuridicaNombre = "SENT."
                ElseIf strSituacionJuridicaNombre = "PROCESADO" Then
                    strSituacionJuridicaNombre = "PROC."
                End If
                Return UCase(strSituacionJuridicaNombre)
            End Get
            Set(ByVal value As String)
                strSituacionJuridicaNombre = value
            End Set
        End Property
        Public Property Flagrancia As Boolean = False
        Public Property Observacion() As String = ""
        Public Property SentenciaPrincipal() As Boolean = False
        Public Property Principal() As Boolean = False
        Public Property SentenciaConcatenado() As String = ""
        Public Property SentenciaAnio() As String = ""
        Public Property SentenciaMes() As String = ""
        Public Property SentenciaDia() As String = ""
        Public Property DocumentoJudicialNum() As String = ""
        Public Property Estado() As Integer = 1
        Public Property _RegioId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property CreaDocJudicialId As Integer = -1
        Public Property ExpedienteVisible As Integer = -1

        '....... propiedades auxiliares
        Public Property Condicion() As Boolean = False
        Public Property InternoExpedienteRefPadreId As Integer = -1
#End Region
#Region "Propiedades_Libertad"
        Public Property DistritoJudicialID() As Integer = -1
        Public Property JuzgadoID() As Integer = -1
        Public Property AutoridadOtro() As String = ""
        Public Property AutoridadOtroCargo() As String = ""
        Public Property EgresoJuez() As String = ""
        Public Property EgresoSecretario() As String = ""
        Public Property EgresoFechaDocRecepcion() As Long = 0
        Public Property Resolucion As Integer = -1
        Public Property ExpedienteReferido As Boolean = False
        Public Property ExpedienteReferido2 As Integer = 0
        Public Property DocumentoTipoID As Integer = -1
        Public Property DocumentoJudicialID As Integer = -1
        Public Property InternoDelitoID As Integer = -1
        Public Property DelitoEspecificoID As Integer = -1
        Public Property int_sen_pad As Integer = 0
#End Region

#Region "Propiedades_Otros"
        Public Property ExpedienteItem() As Integer = -1
#End Region
    End Class
#Region "ExpedienteCol"
    Public Class ExpedienteCol
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
        Public ReadOnly Property Item(ByVal Index As Integer) As Expediente
            Get
                If Index < 0 Then
                    Return Nothing
                End If
                Try
                    Return CType(MyBase.List(Index), Expediente)
                Catch ex As Exception
                    Return Nothing
                End Try

            End Get
        End Property
        Public Function Add(ByVal obj As Expediente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Expediente(ByVal Index As Integer) As Expediente
            Get
                If Index < 0 Then
                    Return Nothing
                End If
                Try
                    Return CType(MyBase.List(Index), Expediente)
                Catch ex As Exception
                    Return Nothing
                End Try

            End Get
        End Property
        Public Function Remove(index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(index)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
    End Class
#End Region
End Namespace
