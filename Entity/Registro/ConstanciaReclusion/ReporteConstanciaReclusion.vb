Namespace Registro.ConstanciaReclusion
    Public Class ReporteConstanciaReclusion
        Public Property item As Integer = -1
        Public Property fechaRecepcionEP As String = ""
        Public Property fechaRecepcionRP As String = ""
        Public Property idTipoSolicitante As Short = -1
        Public Property solicitanteNombre As String = ""
        Public ReadOnly Property solicitante As String
            Get
                Dim value As String = ""

                Select Case idTipoSolicitante
                    Case Type.Enumeracion.enmTipoAutoridadJudicial.poderJudicial
                        value = salaJudicialNombre + "-" + distritoJudicialNombre

                    Case Else
                        value = solicitanteNombre
                End Select

                Return value
            End Get
        End Property
        Public Property distritoJudicialNombre As String = ""
        Public Property salaJudicialNombre As String = ""
        Public Property internoApeNom As String = ""
        Public Property tipoTramite As Short = -1
        Public Property idTipoDocumento As Short = -1
        Public Property tipoDocumentoNombre As String = ""

        Public Property documentoSerie As String = ""
        Public Property documentoNumero As String = ""
        Public Property numeroCR As String = ""
        Public ReadOnly Property documento As String
            Get
                Dim value As String = ""

                If idTipoDocumento = Type.Enumeracion.ConstanciaReclusion.enmTipoDocumento.solicitud Then
                    value = "N° " + documentoSerie + "-" + documentoNumero
                Else
                    value = tipoDocumentoNombre + " " + documentoNumero
                End If

                Return value
            End Get
        End Property
        Public Property fechaExpedicion As String = ""
        Public Property regionNombre As String = ""
        Public Property penalNombre As String = ""
    End Class

End Namespace