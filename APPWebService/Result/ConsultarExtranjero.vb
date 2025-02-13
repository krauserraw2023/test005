Namespace Result
    Public Class ConsultarExtranjero
        Public Property IDTipoDocumento As Short = -1
        Public ReadOnly Property TipoDocumentoNombre As String
            Get
                Dim value As String = ""

                Select Case Me.IDTipoDocumento
                    Case 3
                        value = "C.E. (Carne de Extranjeria)"
                    Case 16
                        value = "PTP (Permiso Temporal Permanencia)"
                End Select

                Return value
            End Get
        End Property
        Public Property NumeroCE As String = ""
        Public Property NumeroPTP As String = ""
        Public ReadOnly Property NumeroDocumento As String
            Get
                Dim value As String = ""

                If Me.NumeroCE.Trim.Length > 5 Then
                    value = Me.NumeroCE
                End If

                If Me.NumeroPTP.Trim.Length > 5 Then
                    value = Me.NumeroPTP
                End If

                Return value
            End Get
        End Property
        Public Property PrimerApellido As String = ""
        Public Property SegundoApellido As String = ""
        Public Property Nombres As String = ""
        Public Property CalidadMigratoria As String = ""
        Public Property FechaNacimientoCadena As String = ""
        Public ReadOnly Property FechaNacimiento As Long
            Get
                Dim value As Long = 0

                If FechaNacimientoCadena.Length > 5 Then
                    value = Legolas.Components.FechaHora.FechaLong(CDate(FechaNacimientoCadena))
                End If

                Return value
            End Get
        End Property
        Public Property SexoCadena As String = ""
        Public ReadOnly Property IDSexo As Short
            Get
                Dim value As Short = -1

                Select Case Me.SexoCadena.ToLower.Trim
                    Case "Femenino".ToLower
                        value = 2
                    Case "Masculino".ToLower
                        value = 1
                End Select
                Return value
            End Get
        End Property
        Public Property NacionalidadCadena As String = ""
        Public Property IDNacionalidad As Integer = -1
        Public Property FotoCadena As String = ""
        Public ReadOnly Property FotoByte As Byte()
            Get
                Dim value As Byte()

                If FotoCadena.Trim.Length > 5 Then
                    value = Convert.FromBase64String(FotoCadena)
                End If

                Return value
            End Get
        End Property

        Public Property HayServicio As Boolean = False
        Public Property ErrorCodigo As Integer = -1
        Public Property ErrorMensaje As String = ""
    End Class

End Namespace