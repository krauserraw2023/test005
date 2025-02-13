Namespace Clasificacion.Documento
    'clase de utilidad para transferir datos, no relacionado con ninguna tabla de bd
    Public Class DatosFicha
        Public Property MaeVariableId As Integer = -1
        Public Property MaeFichaId As Integer = -1
        Public Property VariableNombre As String = ""
        Public Property ValorPuntaje As Integer = 0
        Public Property ValorNoPrevisto As Integer = 0
        Public Property InternoFichaDetalleId As Integer = -1
        Public Property IndicadorId As Integer = -1
        'SCXDSFFDS

        Public Property BloquearRegistro As Boolean = False
        Public Property InternoSituacionJuridica As Integer = -1
        Public Property GrupoFichaId As Integer = -1
    End Class
End Namespace