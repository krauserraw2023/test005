Namespace Reporte.FichaIdentificacion
    Public Class SituacionJuridica
#Region "Propiedades"
        Private lngFechaDocumento As Long = 0
        Private intActoID As Integer = -1
        Private strNumeroDocumento As String = ""
        Private strDocumentoIngreso As String = ""
        Private strDocumentoSalaJuzgado As String = ""
        Private strDocumentoSecretario As String = ""
        Private strComunicaAutoridadJudicial As String = ""        
        Private strNumeroExpediente As String = ""
        Private strExpedienteSalaJuzgado As String = ""
        Private strExpedienteSecretario As String = ""
        Private strObservaciones As String = ""
        Private strIngresoPenal As String = ""
        Private intNumeroIngreso As Integer = -1
        Private strObservacion2 As String = ""
        Private lngCodigo As Long = -1
        Private lngIngresoID As Long = -1
        Private lngExpedienteID As Long = -1
        Private lngFechaRecepcion As Long = 0
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private intPenalDestinoID As Integer = -1
        Private strPenalNombre As String = ""
        Private strPenalDestinoNombre As String = ""
        Private strTipoTraslado As String = ""
        Private strMotivoTraslado As String = ""
        Private strDocumentoObservacion As String = ""
        Public Property TipoActo() As Integer
            Get
                Return intActoID
            End Get
            Set(ByVal value As Integer)
                intActoID = value
            End Set
        End Property
        Public Property NombreTipoDoc() As String = ""
        Public ReadOnly Property Acto() As String
            Get
                Dim value As String = ""

                'Select Case Me.TipoActo
                '    Case 1 'ingreso
                '        value = "Ingreso"
                '    Case 2 'expediente
                '        value = "Detencion"
                '    Case 3 'libertad
                '        value = "Libertad vvvvvvvvvvvvvv"
                '    Case 4 'Traslados
                '        value = "Traslado"
                '    Case 5 'ejecutoria suprema
                '        value = "Ejecutoria Suprema"
                '    Case 6
                '        value = "Ejecutoria Superior"
                '    Case 7
                '        value = "Sustitucion de Pena"
                '    Case 8
                '        value = "Adecuacion de Pena"
                '    Case 9
                '        value = "Refundicion de Sentencia"
                '    Case 10
                '        value = "Integracion de Pena"
                '    Case 11
                '        value = "Conmutacion de Pena"
                '    Case 12
                '        value = "Sentencias"
                '    Case 13
                '        value = "Sentencia Consentida"
                '    Case 14
                '        value = "Correccion Sentencia"
                '    Case 15
                '        value = "Fallecimiento"
                '    Case 16
                '        value = "Fuga"
                'End Select

                Return NombreTipoDoc '"RRRRRRRRRRRRRRRRRRRRRRRRRR"

            End Get
        End Property
        Public Property IngresoID() As Long
            Get
                Return lngIngresoID
            End Get
            Set(ByVal value As Long)
                lngIngresoID = value
            End Set
        End Property
        Public Property ExpedienteID() As Long
            Get
                Return lngExpedienteID
            End Get
            Set(ByVal value As Long)
                lngExpedienteID = value
            End Set
        End Property
        Public Property Codigo() As Long
            Get
                Return lngCodigo
            End Get
            Set(ByVal value As Long)
                lngCodigo = value
            End Set
        End Property
        Public Property NumeroIngreso() As Integer
            Get
                Return intNumeroIngreso
            End Get
            Set(ByVal value As Integer)
                intNumeroIngreso = value
            End Set
        End Property
        Public Property DocumentoIngreso() As String
            Get
                Return strDocumentoIngreso.ToUpper
            End Get
            Set(ByVal value As String)
                strDocumentoIngreso = value
            End Set
        End Property
        Public Property DocumentoNumero() As String
            Get
                Return strNumeroDocumento.ToUpper
            End Get
            Set(ByVal value As String)
                strNumeroDocumento = value
            End Set
        End Property
        Public Property DocumentoFecha() As Long
            Get
                Return lngFechaDocumento
            End Get
            Set(ByVal value As Long)
                lngFechaDocumento = value
            End Set
        End Property
        Public ReadOnly Property FechaDocumentoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.DocumentoFecha)
            End Get
        End Property
        Public Property FechaRecepcion() As Long
            Get
                Return lngFechaRecepcion
            End Get
            Set(ByVal value As Long)
                lngFechaRecepcion = value
            End Set
        End Property
        Public ReadOnly Property FechaRecepcionDate() As Date
            Get
                Dim value As Date = Now

                If Me.FechaRecepcion > 0 Then
                    value = Legolas.Components.FechaHora.FechaDate(Me.FechaRecepcion)
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FechaRecepcionString() As String
            Get
                Dim value As String = ""

                If Me.FechaRecepcion > 0 Then
                    value = Me.FechaRecepcionDate.ToShortDateString
                End If

                Return value
            End Get
        End Property
        Public Property DocumentoSalaJuzgado() As String
            Get
                Return strDocumentoSalaJuzgado.ToUpper
            End Get
            Set(ByVal value As String)
                strDocumentoSalaJuzgado = value
            End Set
        End Property
        Public Property DocumentoSecretario() As String
            Get
                Return strDocumentoSecretario.ToUpper
            End Get
            Set(ByVal value As String)
                strDocumentoSecretario = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property DocumentoObservacion() As String
            Get
                Return strDocumentoObservacion.ToUpper
            End Get
            Set(ByVal value As String)
                strDocumentoObservacion = value
            End Set
        End Property
        Public Property ExpedienteNumero() As String
            Get
                Return strNumeroExpediente.ToUpper
            End Get
            Set(ByVal value As String)
                strNumeroExpediente = value
            End Set
        End Property
        Public Property ExpedienteSalaJuzgado() As String
            Get
                Return strExpedienteSalaJuzgado.ToUpper
            End Get
            Set(ByVal value As String)
                strExpedienteSalaJuzgado = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property ExpedienteSecretario() As String
            Get
                Dim value As String = ""

                If Me.strExpedienteSecretario.Trim = "" Or Me.strExpedienteSecretario.Length < 1 Then
                    value = "N/I"
                Else
                    value = strExpedienteSecretario
                End If
                Return value.ToUpper
            End Get
            Set(ByVal value As String)
                strExpedienteSecretario = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property IngresoPenal() As String
            Get
                Return strIngresoPenal.ToUpper
            End Get
            Set(ByVal value As String)
                strIngresoPenal = value
            End Set
        End Property
        Public Property Observacion() As String
            Get
                Return strObservaciones.ToUpper
            End Get
            Set(ByVal value As String)
                strObservaciones = value
            End Set
        End Property
        Public Property Observacion2() As String
            Get
                Return strObservacion2.ToUpper
            End Get
            Set(ByVal value As String)
                strObservacion2 = value
            End Set
        End Property

        Public Property RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property

        Public Property PenalDestinoID() As Integer
            Get
                Return intPenalDestinoID
            End Get
            Set(ByVal value As Integer)
                intPenalDestinoID = value
            End Set
        End Property
        Public Property PenalDestinoNombre() As String
            Get
                Return strPenalDestinoNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalDestinoNombre = value
            End Set
        End Property

        Public Property MotivoTrasladoNombre() As String
            Get
                Return strMotivoTraslado.ToUpper
            End Get
            Set(ByVal value As String)
                strMotivoTraslado = value
            End Set
        End Property

        Public Property TipoTrasladoNombre() As String
            Get
                Return strTipoTraslado.ToUpper
            End Get
            Set(ByVal value As String)
                strTipoTraslado = value
            End Set
        End Property

        Public Property InsertarLinea() As String = ""

#End Region
    End Class
#Region "SituacionJuridicaCol"
    Public Class SituacionJuridicaCol
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
        Public Function Add(ByVal obj As SituacionJuridica) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property SituacionJuridica(ByVal Index As Integer) As SituacionJuridica
            Get
                Return CType(MyBase.List(Index), SituacionJuridica)
            End Get
        End Property
    End Class
#End Region
End Namespace