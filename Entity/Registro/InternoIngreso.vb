Namespace Registro
    Public Class Ingreso
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property SedeRowId As Integer = -1

        Private intIngresoNro As Integer = -1
        Private strTipoLibertadNombre As String = ""

        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1        
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer=-1
        Public Property RegionNom() As String = ""
        Public Property PenalNom() As String = ""
        Public Property RegionLimaID() As Integer = -1
        Public Property IngresoNro() As Integer
            Get
                Return intIngresoNro
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then
                    intIngresoNro = 0
                Else
                    intIngresoNro = value
                End If
            End Set
        End Property
        Public ReadOnly Property IngresoNroLetra() As String
            Get
                Dim Valor As String = ""
                Dim NomPenal As String = ""
                Select Case Me.IngresoNro
                    Case 0
                        Valor = "[Por Regularizar]"
                    Case 1
                        Valor = "Primer Ingreso"
                    Case 2
                        Valor = "Segundo Ingreso"
                    Case 3
                        Valor = "Tercer Ingreso"
                    Case 4
                        Valor = "Cuarto Ingreso"
                    Case 5
                        Valor = "Quinto Ingreso"
                    Case 6
                        Valor = "Sexto Ingreso"
                    Case 7
                        Valor = "Septimo Ingreso"
                    Case 8
                        Valor = "Octavo Ingreso"
                    Case 9
                        Valor = "Noveno Ingreso"
                    Case 10
                        Valor = "Décimo Ingreso"
                    Case 11
                        Valor = "Onceavo Ingreso"
                    Case 12
                        Valor = "Doceavo Ingreso"
                    Case 13
                        Valor = "Treceavo Ingreso"
                    Case 14
                        Valor = "Catorceavo Ingreso"
                    Case 15
                        Valor = "Quinceavo Ingreso"
                    Case 16
                        Valor = "Dieciseisavo Ingreso"
                    Case 17
                        Valor = "Diecisieteavo Ingreso"
                    Case 18
                        Valor = "Dieciochoavo Ingreso"
                    Case 19
                        Valor = "Diecinueveavo Ingreso"
                    Case 20
                        Valor = "Veinteavo Ingreso"
                    Case Else
                        Valor = Me.IngresoNro
                End Select
                If Me.RegionLimaID = 3 Then
                    NomPenal = Me.PenalNom & "-"
                    Valor = NomPenal & Valor
                End If
                Return Valor
            End Get
        End Property
        Public Property IngresoNroAux() As Integer = 0

        Public Property FechaISP() As Long = 0 'para penal de LM viene a ser la fecha de ingreso al INPE
        Public ReadOnly Property FechaISPDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaISP)
            End Get
        End Property

        Public Property FechaIngreso() As Long = 0
        Public ReadOnly Property FechaIngresoDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
            End Get
        End Property

        Public Property DocumentoIngreso() As String = ""
        Public Property DocumentoFechaRecepcion() As Long = 0
        Public Property DocumentoIngresoFecha() As Long = 0
        Public ReadOnly Property DocumentoIngresoFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.DocumentoIngresoFecha)
            End Get
        End Property
        Public Property IDMovimientoTipo As Short = -1
        Public Property MotivoIngresoID() As Short = -1
        Public Property MotivoIngresoNombre() As String = ""
        Public Property Observacion() As String = ""
        Public ReadOnly Property Eliminar() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image
                objImagen = My.Resources.delete_32
                Return objImagen
            End Get
        End Property
        Public Property DocumentoLibertad() As String = ""
        Public Property DocumentoLibertadFecha() As Long = 0
        Public ReadOnly Property DocumentoLibertadFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.DocumentoLibertadFecha)
            End Get
        End Property
        Public Property LibertadTipoID() As Integer = -1
        Public Property LibertadTipoNombre() As String = ""
        Public Property FechaLibertad() As Long = 0
        Public ReadOnly Property FechaLibertadDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaLibertad)
            End Get
        End Property
        Public ReadOnly Property LibertadIcon() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image

                objImagen = My.Resources.pawn_glass_red

                If Me.FechaLibertad > 0 Then objImagen = My.Resources.pawn_glass_green

                Return objImagen
            End Get

        End Property
        Public Property IngresoInpeId As Integer = -1
        Public Property PerfilUsuarioId As Integer = -1
#End Region

#Region "Propiedades_Otros"
        Public Property PenalNum() As Integer = 0
        Public Property Estado() As Integer = 0
        Public ReadOnly Property EstadoImage() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image = My.Resources.anular

                If Me.Estado > 0 Then
                    objImagen = My.Resources.anular2
                End If
                Return objImagen
            End Get

        End Property
        Public Property SituacionJuridicaID() As Integer = -1
        Public ReadOnly Property SituacionJuridicaNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.SituacionJuridicaID
                    Case 1
                        value = "Procesado"
                    Case 2
                        value = "Sentenciado"
                    Case 3
                        value = "Sent./Proc."
                    Case Else
                        value = "No Registra"
                End Select

                Return value.ToUpper

            End Get

        End Property
        Public Property MovimientoNombre As String = ""
        Public Property FechaIngresoInpe As Long = 0
        Public ReadOnly Property FechaIngresoInpeDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngresoInpe)
            End Get
        End Property

        Public Property IngInpeSedeRowId As Integer = -1
        Public Property Historico As Boolean = 0
        Public Property HistoricoVisible As Integer = 0
#End Region
#Region "Propiedades_Filtro"
        Public Property FechaInicio() As Long = 0
        Public Property FechaFin() As Long = 0
#End Region
    End Class
#Region "IngresoCol"
    Public Class IngresoCol
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
        Public Function Add(ByVal obj As Ingreso) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Ingreso(ByVal Index As Integer) As Ingreso
            Get
                Return CType(MyBase.List(Index), Ingreso)
            End Get
        End Property
    End Class
#End Region
End Namespace
