Namespace Registro.Integracion
    Public Class CodigoUnicoInterno
        Public Property Codigo As Integer = -1
        Public Property TipoNacionalidad As String = "" 'P:Peruano, E:Extranjero
        Public Property CodigoSecuencialUnico As Integer = 0
        Public ReadOnly Property CodigoUnicoInternoStr As String
            Get
                Return TipoNacionalidad & Format(Me.CodigoSecuencialUnico, "000000000")
            End Get
        End Property
    End Class
End Namespace