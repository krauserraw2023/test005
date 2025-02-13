Namespace Registro
    Public Class Expediente
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

        Public Property AutoridadJudicialNombre() As String
            Get
                Return UCase(strAutoridadJudicialNombre) 'Legolas.Components.Cadena.ProperCase(strAutoridadJudicialNombre)
            End Get
            Set(ByVal value As String)
                strAutoridadJudicialNombre = value
            End Set
        End Property
        Public Property SalaJudicialID() As Integer = -1
        Public Property SalaJudicialNombre() As String
            Get
                Return UCase(strSalaJudicialNombre) 'Legolas.Components.Cadena.ProperCase(strSalaJudicialNombre)
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
        Public Property DocFechaDocRecepcion() As Long = 0
        Public ReadOnly Property ExpedienteFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.ExpedienteFecha)
            End Get
        End Property
        Public ReadOnly Property ExpedienteFechaDocRecepcionDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.ExpedienteFechaDocRecepcion)
            End Get
        End Property
        Public ReadOnly Property DocFechaDocRecepcionDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.DocFechaDocRecepcion)
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
                Return UCase(strSituacionJuridicaNombre) 'Legolas.Components.Cadena.ProperCase(strSituacionJuridicaNombre)
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
        Public Property SentenciaCadenaPerpetua As Boolean = False
        Public Property SentenciaFechaInicio As String = ""
        Public Property SentenciaFechaFinal As String = ""
        Public Property DocumentoJudicialNum() As String = ""
        Public Property DocumentoDistritoJudicial() As String = ""
        Public Property DocumentoAutoridadJudicial() As String = ""
        Public Property FechaInicio As Long = 0
        Public Property FechaFinal As Long = 0
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
        Public Property Anulacion As Integer = 0
        Public Property ResolucionID As Integer = -1
        Public Property ResolucionNom As String = ""
        Public Property MotivoQuedaID As Integer = -1
        Public Property MotivoQuedaNom As String = ""
        Public Property MotivoIngresoID As Integer = -1
        Public Property Inimputable As String = ""
        Public Property EstablecimientomentalId As Integer = -1
        Public Property Establecimientomental As String = ""
        Public Property NuevoMotivoInimputableId As Integer = -1
        Public Property NuevoMotivoInimputable As String = ""
        Public Property NuevoEstablecimientomentalId As Integer = -1
        Public Property NuevoEstablecimientomental As String = ""
        Public Property Extramuro As Integer = -1
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
        Public Property Historial As String = ""
        Public Property Condicion() As Boolean = False
        Public Property Contador() As Integer = -1
        Public Property InternoExpedienteRefPadreId As Integer = -1
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
        Public Property DistritoJudicialID() As Integer = -1
        Public Property JuzgadoID() As Integer = -1
        Public Property AutoridadOtro() As String = ""
        Public Property AutoridadOtroCargo() As String = ""
        Public Property EgresoJuez() As String = ""
        Public Property EgresoSecretario() As String = ""
        Public Property DocumentoLibertad() As String = ""
        Public Property DocumentoLibertadFecha() As Long = 0
        Public Property EgresoFechaDocRecepcion() As Long = 0
        Public Property LibertadTipoID() As Integer = -1
        Public Property LibertadAuxiliarID() As Integer = -1
        Public Property LibertadTipoNom() As String = ""
        Public Property LibertadSubTipoID() As Integer = -1
        Public Property LibertadSubTipoStrID() As String = ""
        Public Property LibertadSubTipo() As String = ""
        Public Property FechaLibertad() As Long = 0
        Public Property ObsLibertad() As String = ""
        Public Property ExpedienteReferido As Boolean = False
        Public Property ExpedienteReferidoID As Integer = 0
        Public Property ExpedientePadreReferidoID As Integer = 0
        Public Property DocumentoTipoID As Integer = -1
        Public Property DocumentoTipoCategoria As Integer = -1
        Public Property DocumentoJudicialID As Integer = -1

        Public ReadOnly Property LibertadIcon() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image

                Select Case Me.LibertadTipoID
                    Case Is > 1
                        If Me.FechaLibertad > 0 And Me.DocumentoTipoID <> 14 Then
                            objImagen = My.Resources.libro_verde    'My.Resources.pawn_glass_green
                        Else
                            'objImagen = My.Resources.libro_rojo  ' My.Resources.pawn_glass_red
                            If Me.DocumentoTipoID > 0 And Me.DocumentoTipoID <> 14 Then
                                objImagen = My.Resources.libro_verde ' My.Resources.pawn_glass_red
                            Else
                                objImagen = My.Resources.libro_rojo  ' My.Resources.pawn_glass_red
                            End If
                        End If
                    Case Else
                        If Extramuro = 1 Then
                            objImagen = My.Resources.libro_amarillo  ' My.Resources.pawn_glass_red
                        Else
                            objImagen = My.Resources.libro_rojo  ' My.Resources.pawn_glass_red
                        End If
                End Select
                Return objImagen
            End Get

        End Property
        Public ReadOnly Property LibertadIcon_v5() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image

                Select Case Me.LibertadTipoID
                    Case Is > 1
                        If Me.FechaLibertad > 0 And Me.DocumentoTipoID <> 14 Then
                            objImagen = My.Resources.libro_verde    'My.Resources.pawn_glass_green
                        Else
                            If Me.DocumentoTipoID > 0 Then
                                objImagen = My.Resources.libro_verde ' My.Resources.pawn_glass_red
                            Else
                                objImagen = My.Resources.libro_rojo  ' My.Resources.pawn_glass_red
                            End If
                        End If
                    Case Else
                        objImagen = My.Resources.libro_rojo  ' My.Resources.pawn_glass_red
                End Select
                Return objImagen
            End Get

        End Property
        Public ReadOnly Property ExpedienteRefIcon() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image

                Select Case Me.ExpedienteReferidoID
                    Case Is > 0
                        objImagen = My.Resources.book_link
                    Case Else
                        objImagen = My.Resources.book_link_plomo

                End Select
                Return objImagen
            End Get

        End Property
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
        Public ReadOnly Property EstadoImage() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image = My.Resources.check_box_black

                If Me.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                    objImagen = My.Resources.cuadro_rojo
                ElseIf Me.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                    objImagen = My.Resources.cuadro_naranja
                End If
                Return objImagen
            End Get

        End Property
        Public Sub New()
            lstDelitos = New DelitoCol()
        End Sub
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
