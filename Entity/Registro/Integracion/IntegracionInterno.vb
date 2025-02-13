Namespace Registro.Integracion
    Public Class IntegracionInterno
        Public Property Codigo As Integer = -1
        Public Property CodigoUnicoInternoId As Integer = -1
        Public Property NumeroDocumentoStr As String = ""
        Public Property CodigoUsrUsuario As String = ""
        Public Property UsuarioApellidos As String = ""
        Public Property UsuarioNombres As String = ""
        Public Property FechaIntegracion As Long = 0
        Public Property Observacion As String = ""

        Public Property MotivoIntegracion As String = ""

        Public ReadOnly Property FechaIntegracionStr As String
            Get
                Dim f As String = ""
                If Me.FechaIntegracion > 0 Then f = Legolas.Components.FechaHora.FechaString(Me.FechaIntegracion)
                Return f
            End Get
        End Property

        '----- auxiliares para filtros----
        Public Property TipoNacionalidadStr As String = ""
        Public Property CodigoUnicoSecuencial As Integer = 0
        Public Property FechaIntegracionIni As Long = 0
        Public Property FechaIntegracionFin As Long = 0
        Public Property InternoCodigoRP As String = ""
        Public Property InternoApePaterno As String = ""
        Public Property InternoApeMaterno As String = ""
        Public Property InternoNombres As String = ""

        '-------auxiliares rpta---------
        Public Property TotalInternos As Integer = 0
        Public ReadOnly Property CodigoUnicoInternoStr As String
            Get
                Return TipoNacionalidadStr & Format(Me.CodigoUnicoSecuencial, "000000000")
            End Get
        End Property
        Public ReadOnly Property NombresUsuarioCompleto As String
            Get
                Return Me.UsuarioApellidos & ", " & UsuarioNombres
            End Get
        End Property
    End Class
End Namespace