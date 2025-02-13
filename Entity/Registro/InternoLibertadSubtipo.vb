Namespace Registro
    Public Class ExpedienteLibertadSubtipo
        Inherits Auditoria.Transaccion
#Region "Propiedades_Expediente"
        Private strAutoridadJudicialNombre As String = ""
        Private strSalaJudicialNombre As String = ""
        Private strSituacionJuridicaNombre As String = ""

        Public Property SedeRowId As Integer = -1
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Public Property Codigo() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoNro() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property Internamiento() As Boolean = False
        Public Property TipoAutoridadJudicialID As Integer = -1
        Public Property AutoridadJudicialID() As Integer = -1



        Public Property ExpedienteId() As Integer = -1
        Public Property ExpedienteSecretario() As String = ""
        Public Property ExpedienteNumero() As String = ""
        Public Property ExpedienteFechaDocRecepcion() As Long = 0
        Public Property ExpedienteFecha() As Long = 0





        Public ReadOnly Property Eliminar() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image
                objImagen = My.Resources.delete_32
                Return objImagen
            End Get
        End Property
        Public Property Estado() As Integer = 1
        Public Property EstadoEjecucion() As Integer = 1
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property CreaDocJudicialId As Integer = -1
        Public Property ExpedienteVisible As Integer = -1
        Public Property Nuevo As Boolean = False

        '....... propiedades auxiliares
        Public Property AuxRefDocJudId As Integer = -1 'id del documento judicial el cual hace referencia a los expedientes mediante tabla REG_DOC_DocJudicialExpediente, utilizado en clase metodo Listar_expe_ref capa bussines.
        Private lstDelitos As DelitoCol = Nothing
        Public Property ListaDelitos() As DelitoCol
            Get
                Return lstDelitos
            End Get
            Set(value As DelitoCol)
                lstDelitos = value
            End Set
        End Property
        Public Property RegistroEdidato As Boolean = False
        Public Property CodigoPadre As Integer = -1

        Public Property usuariocreacion As String = ""
        Public Property usuariomodific As String = ""
        Public Property fechacreacion As Long = 0
        Public Property fechamodific As Long = 0
        Public ReadOnly Property fechacreacionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.fechacreacion, True)
            End Get
        End Property
        Public ReadOnly Property fechamodificString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.fechamodific, True)
            End Get
        End Property
#End Region
#Region "Propiedades_Libertad"


        Public Property LibertadTipoID() As Integer = -1
        Public Property LibertadTipoNom() As String = ""
        Public Property LibertadSubTipoID() As Integer = -1
        Public Property LibertadSubTipoStrID() As String = ""
        Public Property LibertadSubTipo() As String = ""

        Public Property DocumentoTipoID As Integer = -1
        Public Property DocumentoJudicialID As Integer = -1


        Public Property InternoDelitoID As Integer = -1
        Public Property DelitoEspecificoID As Integer = -1
        Public Property int_sen_pad As Integer = 0
        Public Property FechaSentencia() As Long = 0
        Public ReadOnly Property FechaSentenciaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaSentencia)
            End Get
        End Property
#End Region

        Public Sub New()
            lstDelitos = New DelitoCol()
        End Sub
#Region "Propiedades_Otros"
        Public Property ExpedienteItem() As Integer = -1
#End Region
    End Class
#Region "ExpedienteCol"
    Public Class ExpedienteLibertadSubtipoCol
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
        Public ReadOnly Property Item(ByVal Index As Integer) As ExpedienteLibertadSubtipo
            Get
                If Index < 0 Then
                    Return Nothing
                End If
                Try
                    Return CType(MyBase.List(Index), ExpedienteLibertadSubtipo)
                Catch ex As Exception
                    Return Nothing
                End Try

            End Get
        End Property
        Public Function Add(ByVal obj As ExpedienteLibertadSubtipo) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Expediente(ByVal Index As Integer) As ExpedienteLibertadSubtipo
            Get
                If Index < 0 Then
                    Return Nothing
                End If
                Try
                    Return CType(MyBase.List(Index), ExpedienteLibertadSubtipo)
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
