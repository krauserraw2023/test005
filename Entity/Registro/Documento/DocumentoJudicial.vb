Namespace Registro
    Public Class DocumentoJudicial
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        Public Property FlagTransferenciaSede As UShort = 0
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property DocumentoTipo() As Integer = -1
        Public Property DocumentoCategoria() As Integer = -1
        Public Property DocumentoNumero() As String = ""
        Public ReadOnly Property DocumentoNumeroReadOnly() As String
            Get
                Dim Valor As String = ""
                If Me.DocumentoTipo = 14 And Me.DocumentoSubTipoId = 4 Then
                    Valor = "Ref. " & Me.DocumentoNumero
                Else
                    Valor = Me.DocumentoNumero
                End If
                Return Valor
            End Get
        End Property
        Public Property DocumentoNumeroTraslado() As String = ""
        Public Property DocumentoFecha() As Long = 0
        Public Property DocumentoFechaRecepcion() As Long = 0
        Public Property DocumentoFechaMovimiento() As Long = 0
        Public Property PenalNombre() As String = ""
        Public Property RegionNombre() As String = ""

        Public Property TipoAutoridadJudicial() As Integer = -1
        Public Property TipoAutoridadJudicialNom As String = ""

        Public Property DistritoJudicial() As Integer = -1
        Public Property SalaJuzgado() As Integer = -1

        Public Property JuezNombre() As String = ""
        Public Property SecretarioNombre() As String = ""
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
        Public Property InternoIngresoId As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoNro As Integer = -1
        Public Property IngresoInpeNro As Integer = -1
        Public Property MovimientoMotivoId As Integer = -1 'movimiento motivo, resolucion de traslado
        Public Property MovimientoMotivoNom As String = ""
        Public Property DocumentoSubTipoId As Integer = -1

        Public Property SituacionJuridicaId As Integer = -1 'situacion juridica del interno
        Public Property Flagrancia As Boolean = 0
        Public Property ProlonDetencionFechIni As Long = 0 'fecha de inicio para resolucion de prolongacion de detencion
        Public Property ProlonDetencionFechFin As Long = 0 'fecha de fin para resolucion de prolongacion de detencion
        Public Property ProlonDetencionTipoUnidad As String = "" 'tipo de unidad Ddia, M:mes, A:año, prolongacion de detencion
        Public Property ProlonDetencionValor As Integer = 0 'valor en funcion al tipo de unidad - Prolongacion de detencion
        '----------especificos para sentencia ---------
        Public Property SentenciaFecha() As Long = 0
        Public Property SentenciaConsentida() As Boolean = False
        Public Property SentenciaCadenaPerpetua() As Boolean = False
        Public Property SentenciaTotalAnios() As Integer = 0
        Public Property SentenciaTotalMeses() As Integer = 0
        Public Property SentenciaTotalDias() As Integer = 0
        'complementarios para grilla
        Public Property DocumentoTipoNombre() As String = ""
        Public Property DocumentoSubTipoNombre() As String = ""
        Public Property observacionEstadoEjecucion() As String = ""
        Public ReadOnly Property DocumentoTipoNombre2() As String
            Get
                Dim Tipo As String
                If Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria _
                    And DocumentoSubTipoId > 0 Then
                    Tipo = Me.DocumentoSubTipoNombre
                ElseIf Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                    If DocumentoSubTipoId = 26 Then
                        Tipo = "NUEVO INGRESO"
                    ElseIf DocumentoSubTipoId = 27 Then
                        Tipo = "INGRESO POR REVOCATORIA"
                    ElseIf DocumentoSubTipoId = 28 Then
                        Tipo = "INGRESO POR TRASLADO"
                    ElseIf DocumentoSubTipoId = 29 Then
                        Tipo = "INGRESO PRISION PREVENTIVA"
                    Else
                        Tipo = DocumentoTipoNombre
                    End If
                ElseIf Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas And DocumentoSubTipoId > 0 Then
                    Tipo = Me.DocumentoSubTipoNombre
                ElseIf Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                    'If Me.Proceso_Pendiente_Queda = 0 Then
                    '    If Me.FechaMovimiento > 0 And Me.mov_est_id = 3 Then
                    '        If Me.MovimientoMotivoId = 176 And Me.EstadoEjecucionId = 3 Then
                    '            Tipo = "LIBERTAD" & " (EJECUTADA)"
                    '        ElseIf Me.MovimientoMotivoId = 176 And Me.EstadoEjecucionId = 1 Then
                    '            Tipo = "LIBERTAD" & " (EJECUTADA EL " & Me.FechaMovimientoString & ")"
                    '        Else
                    '            Tipo = "LIBERTAD" & " (EJECUTADA)"
                    '        End If
                    '    Else
                    '        If Me.EstadoEjecucionId = 4 Then
                    '            Tipo = "LIBERTAD" & " (NO EJECUTADO)"
                    '        ElseIf Me.EstadoEjecucionId = 3 Then
                    '            If Me.MovimientoMotivoId = 176 Then
                    '                Tipo = "LIBERTAD" & " (EJECUTADA EL " & Me.DocumentoFechaMovimentoStr & ")"
                    '            ElseIf Me.MovimientoId = -1 Then
                    '                Tipo = "LIBERTAD (EJECUTADA)"
                    '            Else
                    '                Tipo = "LIBERTAD" & " (EN PROCESO)"
                    '            End If
                    '        Else
                    '            Tipo = "LIBERTAD" & " (EN PROCESO)"
                    '            If Me._Historico = 1 Then
                    '                Tipo = "LIBERTAD (EJECUTADA)"
                    '            End If
                    '        End If
                    '    End If
                    'Else
                    Tipo = DocumentoTipoNombre
                    'End If
                Else
                    Tipo = DocumentoTipoNombre
                End If
                Return Tipo
            End Get
        End Property
        Public Property Estado() As Integer = -1
        Public Property EstadoEjecucionId() As Integer = -1
        Public ReadOnly Property estadoEjecucionNombre As String
            Get

                Dim value As String = ""
                If Me.DocumentoTipo = 70 And Me.EstadoEjecucionId = 1 Then Me.EstadoEjecucionId = 2
                If Me.DocumentoTipo = 74 And Me.EstadoEjecucionId = 1 Then Me.EstadoEjecucionId = 2
                Select Case Me.EstadoEjecucionId
                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo
                        value = "En Desarrollo"

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Apto
                        value = "PENDIENTE DE EJECUCIÓN"

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Ejecutado
                        value = "Ejecutado"

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutado
                        value = "No Ejecutado"

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion1
                        value = "No Ejecutado/Por no ser recibido en hospital mental destino"

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion2
                        value = "No Ejecutado/Por orden judicial"

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion3
                        value = "No Ejecutado/Pendiente de ejecución, por tener otros procesos vigentes"

                End Select
                If Me.DocumentoTipo = 6 Then
                    If Me.Proceso_Pendiente_Queda = 1 Then
                        value = "TERMINADO"
                    Else
                        'Dim estadoMov As Integer = .mov_est_id
                        'If estadoMov = 3 Then
                        '    Me._fechaejecucionMov = .fechaMovimientoEjecucionString
                        'End If
                        If Me.EstadoEjecucionId = 4 Then
                            value = "NO EJECUTADO"
                        ElseIf Me.EstadoEjecucionId = 3 Then
                            If Me.MovimientoId > 0 And Me.mov_est_id = 3 Then
                                value = "EJECUTADO"
                                Me.FechaMovimiento = Me.fechaMovimientoEjecucion
                            ElseIf Me.MovimientoId < 1 And (Me.FechaMovimiento > 0 Or Me.FechaInscripcion > 0) Then
                                value = "EJECUTADO"
                                Me.fechaMovimientoEjecucion = Me.FechaInscripcion
                                Me.FechaMovimiento = Me.FechaInscripcion
                            ElseIf Me._Historico = 1 Then
                                value = "EJECUTADO"
                                Me.fechaMovimientoEjecucion = Me.FechaInscripcion
                                Me.FechaMovimiento = Me.FechaInscripcion
                            Else
                                value = "PENDIENTE DE EJECUCIÓN"
                            End If
                        Else
                            If Me._Historico = 1 Then
                                value = "EJECUTADO"
                                Me.fechaMovimientoEjecucion = Me.FechaInscripcion
                                Me.FechaMovimiento = Me.FechaInscripcion
                            Else
                                If Me.MovimientoId > 0 And Me.mov_est_id = 3 Then
                                    value = "EJECUTADO"
                                Else
                                    value = "PENDIENTE DE EJECUCIÓN"
                                End If
                            End If
                        End If

                    End If

                End If

                Return value.ToUpper

            End Get
        End Property

        Public Property DistritoJudNombre As String = ""
        Public Property SalaJudNombre As String = ""
        Public Property Eliminado As Boolean = False
        Public ReadOnly Property DocumentoFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.DocumentoFecha)
            End Get
        End Property
        Public ReadOnly Property DocumentoFechaRecepDate() As String
            Get
                Dim Value As String = ""
                Select Case Me.DocumentoTipo
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                        Value = Me.fechaMovimientoEjecucionString
                    Case Else
                        Value = Legolas.Components.FechaHora.FechaString(Me.DocumentoFechaRecepcion)
                End Select
                Return Value
            End Get
        End Property
        Public ReadOnly Property DocumentoFechaMovimentoStr() As String
            Get
                Dim Value As String = ""
                Value = Legolas.Components.FechaHora.FechaString(Me.DocumentoFechaMovimiento)
                Return Value
            End Get
        End Property
        Public ReadOnly Property fechaMovimientoEjecucionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.fechaMovimientoEjecucion)
            End Get
        End Property
        Public ReadOnly Property fechaMovimientoEjecucionLongString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.fechaMovimientoEjecucion, True)
            End Get
        End Property
        Public ReadOnly Property FechaMovimientoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaMovimiento)
            End Get
        End Property
        Public ReadOnly Property ProlongacionIniDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.ProlonDetencionFechIni)
            End Get
        End Property
        Public ReadOnly Property ProlongacionFinDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.ProlonDetencionFechFin)
            End Get
        End Property
        Public ReadOnly Property FecSentenciaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.SentenciaFecha)
            End Get
        End Property
        Public ReadOnly Property FechaInscripcionDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInscripcion)
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
        Public Property TipoCategoria As Integer = -1
        Public Property TipoLibertadNom As String = ""
        Public ReadOnly Property Detalle() As String
            Get
                Dim Value As String = ""
                Select Case Me.DocumentoTipo
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                        If Me.DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoPrisionPreventiva Then
                            Dim FechaProlog As String = ""
                            Dim TiempoProlog As String = ""
                            If Me.ProlongacionIniDate <> "" And Me.ProlongacionFinDate <> "" Then
                                FechaProlog = " Fec. de Detencion: " & Me.ProlongacionIniDate & " al " & Me.ProlongacionFinDate
                            End If
                            If Me.ProlonDetencionTipoUnidad <> "" Then
                                TiempoProlog = " Tiempo : " & Me.ProlonDetencionTipoUnidad
                            End If
                            Value = "Fec. Ingreso " & Me.fechaMovimientoEjecucionString & " Penal Ing. " & Me.PenalDestinoNom & FechaProlog & TiempoProlog
                        Else
                            If Me.DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.InternamientoReferenciado Then
                                Value = "Ref. Penal Ing. " & Me.PenalOrigenNom
                            ElseIf Me.DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                                Value = "Fec. Ingreso " & Me.fechaMovimientoEjecucionString & " Penal Orig. " & Me.PenalOrigenNom & " Penal dest. " & Me.PenalDestinoNom
                            Else
                                Value = "Fec. Ingreso " & Me.fechaMovimientoEjecucionString & " Penal Ing. " & Me.PenalDestinoNom
                            End If
                        End If
                        If Me._RegionID = 3 And Me._PenalID = -1 Then ' REGION LIMA
                            Value = "Ingreso al Penal : " & Me.PenalDestinoNom
                        End If
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion
                        Dim FechaProlog As String = ""
                        If Me.ProlongacionIniDate <> "" And Me.ProlongacionFinDate <> "" Then
                            FechaProlog = "Fec. Prolongación desde el " & Me.ProlongacionIniDate & " al " & Me.ProlongacionFinDate
                        ElseIf Me.ProlonDetencionTipoUnidad <> "" And Me.ProlonDetencionValor > 0 Then
                            Dim TipoUni As String = ""
                            If Me.ProlonDetencionTipoUnidad = "D" Then
                                TipoUni = "dia(s)"
                            ElseIf Me.ProlonDetencionTipoUnidad = "M" Then
                                TipoUni = "mes(es)"
                            ElseIf Me.ProlonDetencionTipoUnidad = "A" Then
                                TipoUni = "año(s)"
                            End If
                            FechaProlog = "Tiempo de Prolongación " & Me.ProlonDetencionValor & " " & TipoUni
                        End If
                        Value = FechaProlog
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                        If Me.FechaMovimiento > 0 Then
                            Value = "Fec. Egreso " & Me.FechaMovimientoString & " Libertad " & Me.TipoLibertadNom
                        End If
                    Case Else
                            Select Case Me.TipoCategoria
                            Case 2
                                Dim strEtiqueta As String = " Duración de la condena "
                                If Me.tipoInumputable > 0 Then strEtiqueta = " Duración de la medida de seguridad "
                                Dim FechaSent As String = ""
                                Dim TiempoSent As String = ""
                                If Me.SentenciaFecha > 0 Then
                                    FechaSent = "Fec. Sent. : " & Me.FecSentenciaDate
                                End If
                                If Me.SentenciaTotalAnios = 0 Then
                                    If Me.SentenciaTotalMeses = 0 Then
                                        If Me.SentenciaTotalDias > 0 Then
                                            TiempoSent = strEtiqueta & Me.SentenciaTotalDias & "d"
                                        End If
                                    Else
                                        TiempoSent = strEtiqueta & Me.SentenciaTotalMeses & "m " & Me.SentenciaTotalDias & "d"
                                    End If
                                Else
                                    TiempoSent = strEtiqueta & Me.SentenciaTotalAnios & "a " & Me.SentenciaTotalMeses & "m " & Me.SentenciaTotalDias & "d"
                                End If
                                Value = FechaSent & TiempoSent
                        End Select
                End Select
                Return Value
            End Get
        End Property
        Public Property DocumentoJudicialPenalOrigen As String = ""
        Public Property FechaInternamientoPenalOrigen As Long = 0
        Public Property FechaIngresoPenalOrigen As Long = 0
        Public Property ObservacionPenalOrigen As String = ""
        Public Property IdDocumentoAntecedente() As Integer = -1
        Public Property QuedaId() As Integer = -1
        Public Property fechaMovimientoEjecucion As Long = 0
        Public ReadOnly Property EstadoImage() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image = My.Resources.check_box_black

                If Me.Estado >= Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total Then
                    objImagen = My.Resources.cuadro_rojo

                ElseIf Me.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial Then
                    objImagen = My.Resources.cuadro_naranja
                End If
                Return objImagen
            End Get
        End Property
        Public Property NumeroExpediente As String = ""
        'Indica que el documento es un mandato de detencion que se registró con el internamiento de interno.
        Public Property MandatoDeInternamiento As Short = -1 '1=Mandato de internamiento, 0=otros mandatos, -1=Otro documento
        Public Property MovimientoId As Integer = -1
        'Public Property EstablecimientomentalId As Integer = -1
        'Public Property Establecimientomental As String = ""
        Public Property FechaInscripcion As Long = 0
        Public Property tipoInumputable As Short = -1
        ''/*Datos del queda*/
        Public Property Observacion_Queda As String = ""
        Public Property Proceso_Pendiente_Queda As Integer = -1
        Public Property mov_est_id As Integer = -1
        Public Property Extramuro As Integer = -1
        ''Resolucion que declara consentida
        Public Property FechaResolucion() As Long = 0
        Public Property FechaRecepcionResolucion() As Long = 0
        Public Property _Version() As String = ""
        Public Property _Historico As Integer = 0
        Public Property _FechaHistorico As Long = 0
#End Region
    End Class

#Region "DocumentoJudicialCol"
    Public Class DocumentoJudicialCol
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

        Public Function Add(ByVal obj As DocumentoJudicial) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DocumentoJudicial(ByVal Index As Integer) As DocumentoJudicial
            Get
                Return CType(MyBase.List(Index), DocumentoJudicial)
            End Get
        End Property
        Public Function toList() As List(Of DocumentoJudicial)
            Dim a As New List(Of DocumentoJudicial)
            For Each i As DocumentoJudicial In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
