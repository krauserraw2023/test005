Namespace Registro.ConstanciaReclusion
    Public Class Tramite
        Inherits Entity.Registro.ConstanciaReclusion.Expedicion
        Public Property nro As Integer = -1
        Public Property codigo As Integer = -1
        Public Property idInterno As Integer = -1
        Public Property internoEstado As Short = -1
        Public Property idIngresoInpe As Integer = -1
        Public Property idIngreso As Integer = -1
        Public Property numeroTramite As String = ""
        Public Property numeroCR As String = ""
        Public Property tramiteFechaRegistro As DateTime
        Public Property fechaCR As DateTime
        Public Property fechaCRString As String = ""

        Public Property idTipoSolicitante As Integer = -1
        Public Property tipoSolicitanteNombre As String = ""
        Public Property idDistritoJudicial As Integer = -1
        Public Property distritoJudicialNombre As String = ""
        Public Property idAutoridadJudicial As Integer = -1
        Public Property autoridadJudicialNombre As String = ""
        Public ReadOnly Property solicitanteNombre As String
            Get
                Dim value As String = ""

                Select Case Me.idTipoSolicitante
                    Case Type.Enumeracion.enmTipoAutoridadJudicial.poderJudicial
                        value = autoridadJudicialNombre + "/" + distritoJudicialNombre
                    Case Else
                        value = Me.tipoSolicitanteNombre
                End Select

                Return value
            End Get
        End Property
        Public Property documentoReferenciaTipo As Integer = -1
        Public ReadOnly Property documentoReferenciaTipoNombre As String
            Get
                Dim value As String = ""

                Select Case documentoReferenciaTipo
                    Case Type.Enumeracion.ConstanciaReclusion.enmTipoDocumento.solicitud
                        value = "SOLICITUD"

                    Case Type.Enumeracion.ConstanciaReclusion.enmTipoDocumento.memorando
                        value = "MEMORANDO N° " + documentoReferenciaNumero

                    Case Type.Enumeracion.ConstanciaReclusion.enmTipoDocumento.oficio
                        value = "OFICIO N° " + documentoReferenciaNumero
                End Select

                Return value
            End Get
        End Property
        Public Property serieRecibo As String = ""
        Public Property documentoReferenciaNumero As String = ""
        Public Property documentoReferenciaFecha As DateTime
        Public Property fechaRecepcionEP As DateTime
        Public Property fechaRecepcionRP As DateTime
        Public Property tipoTramite As Short = -1
        Public Property tipoTramiteNombre As String = ""

        Public ReadOnly Property serieNumeroRecibo As String
            Get
                Dim value As String = ""
                If Me.idTipoSolicitante <> Type.Enumeracion.enmTipoAutoridadJudicial.propioInterno Then
                    value = "SIN COSTO"
                Else
                    value = "N° " + serieRecibo + "-" + documentoReferenciaNumero
                End If

                Return value
            End Get
        End Property
        Public Property estado As Short = 1
        Public ReadOnly Property estadoNombre As String
            Get
                Dim value As String = ""
                Select Case estado
                    Case Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente
                        value = "PENDIENTE"

                    Case Type.Enumeracion.ConstanciaReclusion.enmEstado.atendido
                        value = "ATENDIDO"

                    Case Type.Enumeracion.ConstanciaReclusion.enmEstado.anulado
                        value = "ANULADO"
                End Select

                Return value
            End Get
        End Property
        Public Property observacion As String = ""
        Public Property observacionAnulacion As String = ""
        Public Property usuarioCR As String = ""
        Public Property idRegion() As Integer = -1
        Public Property RegionNombre As String = ""
        Public Property idPenal() As Integer = -1
        Public Property penalNombre As String = ""
        Public Property penalTipoLicencia As Short = -1
        Public ReadOnly Property getRegionPenalNombre As String
            Get
                Dim value As String = ""

                value = RegionNombre + " - " + penalNombre

                Return value
            End Get

        End Property
#Region "Busqueda"
        ' Opciones de busqueda
        Public Property tipoBusquedaFecha As Integer = 0
        Public Property fechaBusquedaInicio As DateTime
        Public Property fechaBusquedaFinal As DateTime
        Public Property contadorCR As Integer = -1
#End Region

    End Class
End Namespace

