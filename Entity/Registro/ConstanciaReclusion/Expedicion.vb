Namespace Registro.ConstanciaReclusion
    Public Class Expedicion
        Public Property internoCodigoRD As String = ""
        Public Property internoPrimerApellido As String = ""
        Public Property internoSegundoApellido As String = ""
        Public Property internoApellidos As String = ""
        Public Property internoNombre As String = ""
        Public Property internoApellidosyNombres As String = ""
        Public ReadOnly Property getInternoApellidosNombre As String
            Get
                Return internoPrimerApellido + " " + internoSegundoApellido + ", " + internoNombre
            End Get
        End Property
        Public Property internoNombreAsociado As String = ""
        Public Property internoIdFotoPerfilCentro As Integer = -1
        Public Property internoFotoBase64 As String = ""
        Public Property internoFechaIngSistPen As String = ""
        Public Property internoFechaIngreso As String = ""
        Public Property internoMovimientoFechaEgreso As String = ""
        Public Property idExpediente As Integer = -1
        Public Property idDistritoJudicialResp As Integer = -1
        Public Property expedienteSitJur As Short = -1
        Public Property idSalaJudicialResp As Integer = -1
        Public Property salaJuzgadoNombre As String = ""
        Public Property expedienteNumeroResp As String = ""
        Public Property expedienteSecretarioResp As String = ""
        Public Property expedienteDelitoResp As String = ""
    End Class
End Namespace

