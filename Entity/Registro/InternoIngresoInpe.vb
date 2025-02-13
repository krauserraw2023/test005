Namespace Registro
    Public Class IngresoInpe
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IDIngreso As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property RegistroCreaPenalID() As Integer = -1 'id del penal donde se crea el registro
        Public Property PenalNom() As String = ""
        Public Property RegionLimaID() As Integer = -1
        Public Property IngresoNro() As Integer = 0
        Public Property PerfilUsuarioId As Integer = -1
        Public ReadOnly Property IngresoNroLetra() As String
            Get
                Dim Valor As String = ""
                Dim blnGuion As Boolean = False
                Dim strGuion As String = " - "
                Dim strFechaIngresoInpe As String = ""

                Select Case Me.IDTipoMovimiento

                    Case Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD
                        strFechaIngresoInpe = " - " & Me.FechaISPDate
                    Case Else

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
                        blnGuion = True
                End Select

                If blnGuion = False Then
                    strGuion = ""
                End If

                Valor = Valor & " (" & FechaISPDate & ")" & strGuion & Me.TipoMovimientoNombre & strFechaIngresoInpe
                Return Valor

            End Get
        End Property

        Public Property FechaISP() As Long = 0
        Public ReadOnly Property FechaISPDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaISP)
            End Get
        End Property
        Public Property FechaIngInpe() As Long = 0

        Public Property FechaMovimientoIngreso() As Long = 0 'fecha de ingreso a carceleta 
        Public ReadOnly Property getFechaMovIngresoString() As String
            Get
                Dim Fecha As String = Legolas.Components.FechaHora.FechaString(Me.FechaMovimientoIngreso)
                Return Fecha
            End Get
        End Property
        Public ReadOnly Property FechaMovIngresoString() As String
            Get
                Dim Fecha As String = Legolas.Components.FechaHora.FechaString(Me.FechaMovimientoIngreso)
                If Fecha.Length = 0 Then
                    Fecha = "NO REGISTRA"
                End If
                Return Fecha
            End Get
        End Property
        Public Property FechaIngresoPenal As Long = 0
        Public ReadOnly Property getFechaIngresoPenalString As String
            Get
                Dim value As String = ""

                value = Legolas.Components.FechaHora.FechaString(Me.FechaIngresoPenal)

                Return value
            End Get
        End Property
        Public Property IngresoNroAux() As Short = 0
        Public Property IDTipoMovimiento As Short = -1
        Public Property TipoMovimientoNombre As String = ""
        Public Property MotivoIngresoID As Short = -1
        Public Property MotivoIngresoNombre As String = ""
        Public Property Observacion() As String = ""
        Public Property getROrigen As String
        '    Get
        '        Dim value As String = ""

        '        Select Case Me.PenalID
        '            Case 35 'carceleta
        '                value = "E.T.P. Lima"
        '            Case Else
        '                value = "O.R. Lima"
        '        End Select

        '        Return value
        '    End Get
        'End Property
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
        Public Property Historico As Boolean = False
        Public Property HistoricoFecha As Long = 0
        Public Property HistoricoVisible As Integer = 0
        Public Property EstadoId As Integer = -1
#End Region

#Region "Propiedades_Ingreso"
        Public Property DocumentoClasificID() As Integer = -1
        Public Property DocumentoLibertadFecha() As Long = 0
        Public Property LibertadTipoID() As Integer = -1
        Public Property LibertadTipoNombre() As String = ""
        Public Property FechaLibertad() As Long = 0

        Public ReadOnly Property FechaLibertadDate() As String
            Get
                Dim Fecha As String = Legolas.Components.FechaHora.FechaString(Me.FechaLibertad)
                Return Fecha
            End Get
        End Property
        Public ReadOnly Property strFechaLibertadDate() As String
            Get
                Dim Fecha As String = Legolas.Components.FechaHora.FechaString(Me.FechaLibertad)
                If Fecha.Length = 0 Then
                    Fecha = "NO REGISTRA"
                End If
                Return Fecha
            End Get
        End Property

        Public ReadOnly Property LibertadIcon() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image

                objImagen = My.Resources.pawn_glass_red

                If Me.FechaLibertad > 0 And Me.LibertadTipoID > 0 Then
                    objImagen = My.Resources.pawn_glass_green
                End If

                Return objImagen
            End Get

        End Property

#End Region
#Region "Propiedades_Filtro"
        Public Property FechaInicio() As Long = 0
        Public Property FechaFin() As Long = 0
#End Region
    End Class

End Namespace
